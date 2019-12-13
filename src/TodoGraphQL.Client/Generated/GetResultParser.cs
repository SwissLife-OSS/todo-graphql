using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using StrawberryShake;
using StrawberryShake.Configuration;
using StrawberryShake.Http;
using StrawberryShake.Http.Subscriptions;
using StrawberryShake.Transport;

namespace SwissLife.OSS.TodoGraphQL.Client
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public class GetResultParser
        : JsonResultParserBase<IGet>
    {
        private readonly IValueSerializer _iDSerializer;
        private readonly IValueSerializer _todoStatusSerializer;
        private readonly IValueSerializer _stringSerializer;

        public GetResultParser(IValueSerializerCollection serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _iDSerializer = serializerResolver.Get("ID");
            _todoStatusSerializer = serializerResolver.Get("TodoStatus");
            _stringSerializer = serializerResolver.Get("String");
        }

        protected override IGet ParserData(JsonElement data)
        {
            return new Get1
            (
                ParseGetGet(data, "get")
            );

        }

        private IReadOnlyList<ITodo> ParseGetGet(
            JsonElement parent,
            string field)
        {
            JsonElement obj = parent.GetProperty(field);

            int objLength = obj.GetArrayLength();
            var list = new ITodo[objLength];
            for (int objIndex = 0; objIndex < objLength; objIndex++)
            {
                JsonElement element = obj[objIndex];
                list[objIndex] = new Todo
                (
                    DeserializeID(element, "id"),
                    DeserializeTodoStatus(element, "status"),
                    DeserializeString(element, "title")
                );

            }

            return list;
        }

        private string DeserializeID(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (string)_iDSerializer.Deserialize(value.GetString())!;
        }

        private TodoStatus DeserializeTodoStatus(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (TodoStatus)_todoStatusSerializer.Deserialize(value.GetString())!;
        }

        private string DeserializeString(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (string)_stringSerializer.Deserialize(value.GetString())!;
        }
    }
}
