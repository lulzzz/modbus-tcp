﻿using Karonda.ModbusTcp.Entity;
using Karonda.ModbusTcp.Entity.Function.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Karonda.ModbusTcp
{
    public abstract class ModbusResponseService
    {
        public ModbusFunction Execute(ModbusFunction function)
        {
            if (function is ReadCoilsRequest)
            {
                var request = (ReadCoilsRequest)function;
                return ReadCoils(request);
            }
            else if (function is ReadDiscreteInputsRequest)
            {
                var request = (ReadDiscreteInputsRequest)function;
                return ReadDiscreteInputs(request);
            }
            else if (function is ReadHoldingRegistersRequest)
            {
                var request = (ReadHoldingRegistersRequest)function;
                return ReadHoldingRegisters(request);

            }
            else if (function is ReadInputRegistersRequest)
            {
                var request = (ReadInputRegistersRequest)function;
                return ReadInputRegisters(request);
            }

            throw new Exception("Function Not Support");
        }
        public abstract ModbusFunction ReadCoils(ReadCoilsRequest request);

        public abstract ModbusFunction ReadDiscreteInputs(ReadDiscreteInputsRequest request);

        public abstract ModbusFunction ReadHoldingRegisters(ReadHoldingRegistersRequest request);

        public abstract ModbusFunction ReadInputRegisters(ReadInputRegistersRequest request);
    }
}