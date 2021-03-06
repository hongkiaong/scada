﻿/*
 * Copyright 2016 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaData
 * Summary  : Represents errors that thrown from Rapid SCADA source code
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2016
 * Modified : 2016
 */

using System;

namespace Scada
{
    /// <summary>
    /// Represents errors that thrown from Rapid SCADA source code
    /// <para>Представляет ошибки, вызванные из исходного кода Rapid SCADA</para>
    /// </summary>
    public class ScadaException : Exception
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ScadaException()
            : base()
        {
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public ScadaException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public ScadaException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
