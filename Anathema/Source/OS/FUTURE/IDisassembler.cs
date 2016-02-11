﻿/*
 * MemorySharp Library
 * http://www.binarysharp.com/
 *
 * Copyright (C) 2012-2014 Jämes Ménétrey (a.k.a. ZenLulz).
 * This library is released under the MIT License.
 * See the file LICENSE for more information.
*/

using SharpDisasm;
using System;
using System.Collections.Generic;

namespace Anathema
{
    /// <summary>
    /// Interface defining a disassembler.
    /// </summary>
    public interface IDisassembler
    {
        /// <summary>
        /// Disassemble the specified assembly code.
        /// </summary>
        /// <param name="Bytes">The raw bytes.</param>
        /// <returns>A string containing the assembly.</returns>
        List<Instruction> Disassemble(Byte[] Bytes, Boolean Architecture32Bit, UInt64 Address);

    } // End class

} // End namespace