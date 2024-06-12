using System.Text.Json.Serialization;

namespace Fina.Core.Responses;

public class Response<TData>
{
    private int _code = Configuration.DefaultStatusCode;

    [JsonConstructor]
    public Response()
        => _code = Configuration.DefaultStatusCode;

    public Response(
        TData data,
        int code = Configuration.DefaultStatusCode,
        string? message = null) // por est� setando um valor padr�o com o "=" esses par�metros s�o opcionais na hora de criar a classe
    {
        Data  = data;
        _code = code;
        Message = message;
    }

    public TData? Data { get; set; }
    public string? Message { get; set; }

    [JsonIgnore]
    public bool IsSuccess => _code is >= 200 and <= 299;
}