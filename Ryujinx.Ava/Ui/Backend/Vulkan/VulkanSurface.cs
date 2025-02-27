using System;
using Avalonia;
using Ryujinx.Ava.Ui.Vulkan.Surfaces;
using Silk.NET.Vulkan;
using Silk.NET.Vulkan.Extensions.KHR;

namespace Ryujinx.Ava.Ui.Vulkan
{
    public class VulkanSurface : IDisposable
    {
        private readonly VulkanInstance _instance;
        private readonly IVulkanPlatformSurface _vulkanPlatformSurface;

        private VulkanSurface(IVulkanPlatformSurface vulkanPlatformSurface, VulkanInstance instance)
        {
            _vulkanPlatformSurface = vulkanPlatformSurface;
            _instance = instance;
            ApiHandle = vulkanPlatformSurface.CreateSurface(instance);
        }

        internal SurfaceKHR ApiHandle { get; }

        internal static KhrSurface SurfaceExtension { get; private set; }

        internal PixelSize SurfaceSize => _vulkanPlatformSurface.SurfaceSize;

        public void Dispose()
        {
            SurfaceExtension.DestroySurface(_instance.InternalHandle, ApiHandle, Span<AllocationCallbacks>.Empty);
            _vulkanPlatformSurface.Dispose();
        }

        internal static VulkanSurface CreateSurface(VulkanInstance instance, IVulkanPlatformSurface vulkanPlatformSurface)
        {
            if (SurfaceExtension == null)
            {
                instance.Api.TryGetInstanceExtension(instance.InternalHandle, out KhrSurface extension);

                SurfaceExtension = extension;
            }

            return new VulkanSurface(vulkanPlatformSurface, instance);
        }

        internal bool CanSurfacePresent(VulkanPhysicalDevice physicalDevice)
        {
            SurfaceExtension.GetPhysicalDeviceSurfaceSupport(physicalDevice.InternalHandle, physicalDevice.QueueFamilyIndex, ApiHandle, out var isSupported);

            return isSupported;
        }

        internal SurfaceFormatKHR GetSurfaceFormat(VulkanPhysicalDevice physicalDevice)
        {
            Span<uint> surfaceFormatsCount = stackalloc uint[1];
            SurfaceExtension.GetPhysicalDeviceSurfaceFormats(physicalDevice.InternalHandle, ApiHandle, surfaceFormatsCount, Span<SurfaceFormatKHR>.Empty);
            Span<SurfaceFormatKHR> surfaceFormats = stackalloc SurfaceFormatKHR[(int)surfaceFormatsCount[0]];
            SurfaceExtension.GetPhysicalDeviceSurfaceFormats(physicalDevice.InternalHandle, ApiHandle, surfaceFormatsCount, surfaceFormats);

            if (surfaceFormats.Length == 1 && surfaceFormats[0].Format == Format.Undefined)
            {
                return new SurfaceFormatKHR(Format.B8G8R8A8Unorm, ColorSpaceKHR.ColorspaceSrgbNonlinearKhr);
            }

            foreach (var format in surfaceFormats)
            {
                if (format.Format == Format.B8G8R8A8Unorm && format.ColorSpace == ColorSpaceKHR.ColorspaceSrgbNonlinearKhr)
                {
                    return format;
                }
            }

            return surfaceFormats[0];
        }
    }
}
