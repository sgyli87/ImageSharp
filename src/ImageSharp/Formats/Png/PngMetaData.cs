﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

namespace SixLabors.ImageSharp.Formats.Png
{
    /// <summary>
    /// Provides Png specific metadata information for the image.
    /// </summary>
    public class PngMetaData
    {
        /// <summary>
        /// Gets or sets the number of bits per sample or per palette index (not per pixel).
        /// Not all values are allowed for all <see cref="ColorType"/> values.
        /// </summary>
        public PngBitDepth BitDepth { get; set; } = PngBitDepth.Bit8;

        /// <summary>
        /// Gets or sets the color type.
        /// </summary>
        public PngColorType ColorType { get; set; } = PngColorType.RgbWithAlpha;

        /// <summary>
        /// Gets or sets the gamma value for the image.
        /// </summary>
        public float Gamma { get; set; }
    }
}