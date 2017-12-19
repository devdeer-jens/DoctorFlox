﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devdeer.DoctorFlox.Ui.WpfSample.Enumerations
{
    /// <summary>
    /// Defines possible window types for this assembly.
    /// </summary>
    public enum WindowType
    {

        /// <summary>
        /// Invalid window type.
        /// </summary>
        Unkown = 0,

        /// <summary>
        /// The <see cref="MainWindow"/>.
        /// </summary>
        MainWindow = 1,

        /// <summary>
        /// The <see cref="ChildWindow"/>.
        /// </summary>
        ChildWindow = 2,

        /// <summary>
        /// The <see cref="CollectionWindow"/>.
        /// </summary>
        CollectionWindow = 3

    }
}