using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace SwissLife.OSS.TodoGraphQL.Client
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public class TodoStatusValueSerializer
        : IValueSerializer
    {
        public string Name => "TodoStatus";

        public ValueKind Kind => ValueKind.Enum;

        public Type ClrType => typeof(TodoStatus);

        public Type SerializationType => typeof(string);

        public object? Serialize(object? value)
        {
            if (value is null)
            {
                return null;
            }

            var enumValue = (TodoStatus)value;

            switch(enumValue)
            {
                case TodoStatus.Active:
                    return "ACTIVE";
                case TodoStatus.Completed:
                    return "COMPLETED";
                default:
                    throw new NotSupportedException();
            }
        }

        public object? Deserialize(object? serialized)
        {
            if (serialized is null)
            {
                return null;
            }

            var stringValue = (string)serialized;

            switch(stringValue)
            {
                case "ACTIVE":
                    return TodoStatus.Active;
                case "COMPLETED":
                    return TodoStatus.Completed;
                default:
                    throw new NotSupportedException();
            }
        }

    }
}
