﻿// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2023, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Core.DataReader.Mov
{
    public sealed class MovFileReader : IFileReader<MovFile>
    {
        public MovFile Read(byte[] data)
        {
            return new MovFile();
        }
    }
}