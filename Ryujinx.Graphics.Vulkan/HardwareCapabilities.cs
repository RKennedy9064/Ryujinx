﻿using Silk.NET.Vulkan;

namespace Ryujinx.Graphics.Vulkan
{
    struct HardwareCapabilities
    {
        public readonly bool SupportsIndexTypeUint8;
        public readonly bool SupportsCustomBorderColor;
        public readonly bool SupportsIndirectParameters;
        public readonly bool SupportsFragmentShaderInterlock;
        public readonly bool SupportsGeometryShaderPassthrough;
        public readonly bool SupportsSubgroupSizeControl;
        public readonly bool SupportsConditionalRendering;
        public readonly bool SupportsExtendedDynamicState;
        public readonly bool SupportsMultiView;
        public readonly bool SupportsNullDescriptors;
        public readonly bool SupportsPushDescriptors;
        public readonly bool SupportsTransformFeedback;
        public readonly bool SupportsTransformFeedbackQueries;
        public readonly bool SupportsGeometryShader;
        public readonly uint MinSubgroupSize;
        public readonly uint MaxSubgroupSize;
        public readonly ShaderStageFlags RequiredSubgroupSizeStages;

        public HardwareCapabilities(
            bool supportsIndexTypeUint8,
            bool supportsCustomBorderColor,
            bool supportsIndirectParameters,
            bool supportsFragmentShaderInterlock,
            bool supportsGeometryShaderPassthrough,
            bool supportsSubgroupSizeControl,
            bool supportsConditionalRendering,
            bool supportsExtendedDynamicState,
            bool supportsMultiView,
            bool supportsNullDescriptors,
            bool supportsPushDescriptors,
            bool supportsTransformFeedback,
            bool supportsTransformFeedbackQueries,
            bool supportsGeometryShader,
            uint minSubgroupSize,
            uint maxSubgroupSize,
            ShaderStageFlags requiredSubgroupSizeStages)
        {
            SupportsIndexTypeUint8 = supportsIndexTypeUint8;
            SupportsCustomBorderColor = supportsCustomBorderColor;
            SupportsIndirectParameters = supportsIndirectParameters;
            SupportsFragmentShaderInterlock = supportsFragmentShaderInterlock;
            SupportsGeometryShaderPassthrough = supportsGeometryShaderPassthrough;
            SupportsSubgroupSizeControl = supportsSubgroupSizeControl;
            SupportsConditionalRendering = supportsConditionalRendering;
            SupportsExtendedDynamicState = supportsExtendedDynamicState;
            SupportsMultiView = supportsMultiView;
            SupportsNullDescriptors = supportsNullDescriptors;
            SupportsPushDescriptors = supportsPushDescriptors;
            SupportsTransformFeedback = supportsTransformFeedback;
            SupportsTransformFeedbackQueries = supportsTransformFeedbackQueries;
            SupportsGeometryShader = supportsGeometryShader;
            MinSubgroupSize = minSubgroupSize;
            MaxSubgroupSize = maxSubgroupSize;
            RequiredSubgroupSizeStages = requiredSubgroupSizeStages;
        }
    }
}
