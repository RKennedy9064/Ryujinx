﻿namespace Ryujinx.Graphics.GAL.Multithreading
{
    enum CommandType : byte
    {
        Action,
        CreateBuffer,
        CreateProgram,
        CreateSampler,
        CreateSync,
        CreateTexture,
        GetCapabilities,
        Unused,
        PreFrame,
        ReportCounter,
        ResetCounter,
        UpdateCounters,

        BufferDispose,
        BufferGetData,
        BufferSetData,

        CounterEventDispose,
        CounterEventFlush,

        ProgramDispose,
        ProgramGetBinary,
        ProgramCheckLink,

        SamplerDispose,

        TextureCopyTo,
        TextureCopyToScaled,
        TextureCopyToSlice,
        TextureCreateView,
        TextureGetData,
        TextureGetDataSlice,
        TextureRelease,
        TextureSetData,
        TextureSetDataSlice,
        TextureSetStorage,

        WindowPresent,

        Barrier,
        BeginTransformFeedback,
        ClearBuffer,
        ClearRenderTargetColor,
        ClearRenderTargetDepthStencil,
        CommandBufferBarrier,
        CopyBuffer,
        DispatchCompute,
        Draw,
        DrawIndexed,
        DrawTexture,
        EndHostConditionalRendering,
        EndTransformFeedback,
        MultiDrawIndirectCount,
        MultiDrawIndexedIndirectCount,
        SetAlphaTest,
        SetBlendState,
        SetDepthBias,
        SetDepthClamp,
        SetDepthMode,
        SetDepthTest,
        SetFaceCulling,
        SetFrontFace,
        SetStorageBuffers,
        SetTransformFeedbackBuffers,
        SetUniformBuffers,
        SetImage,
        SetIndexBuffer,
        SetLineParameters,
        SetLogicOpState,
        SetMultisampleState,
        SetPatchParameters,
        SetPointParameters,
        SetPolygonMode,
        SetPrimitiveRestart,
        SetPrimitiveTopology,
        SetProgram,
        SetRasterizerDiscard,
        SetRenderTargetColorMasks,
        SetRenderTargetScale,
        SetRenderTargets,
        SetScissor,
        SetStencilTest,
        SetTextureAndSampler,
        SetUserClipDistance,
        SetVertexAttribs,
        SetVertexBuffers,
        SetViewports,
        TextureBarrier,
        TextureBarrierTiled,
        TryHostConditionalRendering,
        TryHostConditionalRenderingFlush,
        UpdateRenderScale
    }
}
