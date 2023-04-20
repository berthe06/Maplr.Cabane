using System;

namespace Maplr.Cabane.Core.Dtos;
public class Response<T>
{
  public String Message { get; set; }
  public Int32 HttpStatus { get; set; }
  public String? StackTrace { get; set; }
  public Boolean Success { get; set; } = true;
  public Int32 Total { get; set; }
  public T Data { get; set; }
}
