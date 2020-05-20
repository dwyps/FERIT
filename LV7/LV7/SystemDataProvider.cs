﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            /*if (currentLoad != this.previousCPULoad)
            {
                this.Notify();
            }*/
            if(Math.Abs(currentLoad - previousCPULoad) >= 0.1 * this.previousCPULoad)
                this.Notify();
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float currentRAM = this.AvailableRAM;
            /*if (currentRAM != this.previousRAMAvailable)
            {
                this.Notify();
            }*/
            if (Math.Abs(currentRAM - previousRAMAvailable) >= 0.1 * this.previousRAMAvailable)
                this.Notify();
            this.previousRAMAvailable = currentRAM;
            return currentRAM;
        }
    }
}
