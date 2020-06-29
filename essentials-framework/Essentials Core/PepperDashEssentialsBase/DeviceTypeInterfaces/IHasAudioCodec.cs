﻿namespace PepperDash.Essentials.Core.Devices.AudioCodec
{
    /// <summary>
    /// For rooms that have audio codec
    /// </summary>
    public interface IHasAudioCodec
    {
        AudioCodecBase AudioCodec { get; }
        BoolFeedback InCallFeedback { get; }

        ///// <summary>
        ///// Make this more specific
        ///// </summary>
        //List<PepperDash.Essentials.Devices.Common.Codec.CodecActiveCallItem> ActiveCalls { get; }
    }
}