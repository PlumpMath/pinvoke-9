﻿#region Copyright Notice
// 
// 
// Copyright (c) 2009-2010 Anindya Chatterjee
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// 
// 
#endregion
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows.Structs
{
    /// <summary>
    /// The GRADIENT_RECT structure specifies the index of two vertices in the 
    /// pVertex array in the GradientFill function. These two vertices form the 
    /// upper-left and lower-right boundaries of a rectangle.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct GradientRect
    {
        /// <summary>
        /// Specifies the upper-left corner of a rectangle
        /// </summary>
        public uint UpperLeft;

        /// <summary>
        /// Specifies the lower-right corner of a rectangle
        /// </summary>
        public uint LowerRight;
    }
}