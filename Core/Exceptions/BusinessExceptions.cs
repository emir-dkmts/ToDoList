namespace Core.Exceptions;

public sealed class BusinessExceptions(string message) : Exception(message);
