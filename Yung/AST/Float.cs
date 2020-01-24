﻿using System;
using Yung.Exceptions;

namespace Yung.AST
{
    public class Float : INumber
    {
        public Float(float value)
        {
            Value = value;
        }

        public float Value { get; }

        public INumber Negate()
        {
            return new Float(-Value);
        }

        public INumber Add(INumber number)
        {
            try
            {
                return new Float(Value + ((Float) number).Value);
            }
            catch (InvalidCastException)
            {
                throw new TypeMismatch();
            }
        }

        public INumber Subtract(INumber number)
        {
            try
            {
                return new Float(Value - ((Float) number).Value);
            }
            catch (InvalidCastException)
            {
                throw new TypeMismatch();
            }
        }

        public INumber Multiply(INumber number)
        {
            try
            {
                return new Float(Value * ((Float) number).Value);
            }
            catch (InvalidCastException)
            {
                throw new TypeMismatch();
            }
        }

        public INumber Divide(INumber number)
        {
            try
            {
                return new Float(Value / ((Float) number).Value);
            }
            catch (InvalidCastException)
            {
                throw new TypeMismatch();
            }
        }
    }
}
