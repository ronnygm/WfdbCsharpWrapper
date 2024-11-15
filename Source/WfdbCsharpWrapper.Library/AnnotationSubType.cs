using System;
using System.Collections.Generic;
using System.Text;

namespace WfdbCsharpWrapper
{

    public enum AnnotationSubType : byte
    {
        /// <summary>
        /// SubType for Heart Rate Measurements (HR)
        /// </summary>
        HR = 0,
        /// <summary>
        /// SubType for Heart Rate Variability Neasurements (HRV)
        /// </summary>
        HRV = 1,
        /// <summary>
        /// SubType for Heart Rate Trubulence Neasurements (HRT)
        /// </summary>
        HRT = 2
    }
}
