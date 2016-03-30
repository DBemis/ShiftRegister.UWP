﻿namespace Anheledir.NET.UWP.IoT
{
  public class NoGPIOControllerFoundException : System.Exception
  {
    public NoGPIOControllerFoundException()
    {
    }

    public NoGPIOControllerFoundException(string message) : base(message)
    {
    }

    public NoGPIOControllerFoundException(string message, System.Exception inner) : base(message, inner)
    {
    }
  }
}