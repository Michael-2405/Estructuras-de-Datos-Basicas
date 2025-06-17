namespace GestionsEstudiantes.Common
{
  /// <summary>
  /// Representa el resultado de una operación, con información sobre éxito, mensaje y datos adicionales.
  /// </summary>
  public class OperationResult
  {
    public string? Message { get; set; }
    public bool? Success { get; set; }
    public dynamic? Data { get; set; }

    public OperationResult() { }

    /// <summary>
    /// Constructor del resultado de operación.
    /// </summary>
    public OperationResult(bool success, string message, dynamic data = null)
    {
      Success = success;
      Message = message;
      Data = data;
    }
  }
}
