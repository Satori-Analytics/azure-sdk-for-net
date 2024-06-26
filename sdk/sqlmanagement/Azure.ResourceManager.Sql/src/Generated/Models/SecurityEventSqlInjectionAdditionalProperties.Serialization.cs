// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SecurityEventSqlInjectionAdditionalProperties : IUtf8JsonSerializable, IJsonModel<SecurityEventSqlInjectionAdditionalProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityEventSqlInjectionAdditionalProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityEventSqlInjectionAdditionalProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityEventSqlInjectionAdditionalProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ThreatId))
            {
                writer.WritePropertyName("threatId"u8);
                writer.WriteStringValue(ThreatId);
            }
            if (options.Format != "W" && Optional.IsDefined(Statement))
            {
                writer.WritePropertyName("statement"u8);
                writer.WriteStringValue(Statement);
            }
            if (options.Format != "W" && Optional.IsDefined(StatementHighlightOffset))
            {
                writer.WritePropertyName("statementHighlightOffset"u8);
                writer.WriteNumberValue(StatementHighlightOffset.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StatementHighlightLength))
            {
                writer.WritePropertyName("statementHighlightLength"u8);
                writer.WriteNumberValue(StatementHighlightLength.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteNumberValue(ErrorCode.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorSeverity))
            {
                writer.WritePropertyName("errorSeverity"u8);
                writer.WriteNumberValue(ErrorSeverity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SecurityEventSqlInjectionAdditionalProperties IJsonModel<SecurityEventSqlInjectionAdditionalProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityEventSqlInjectionAdditionalProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityEventSqlInjectionAdditionalProperties(document.RootElement, options);
        }

        internal static SecurityEventSqlInjectionAdditionalProperties DeserializeSecurityEventSqlInjectionAdditionalProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string threatId = default;
            string statement = default;
            int? statementHighlightOffset = default;
            int? statementHighlightLength = default;
            int? errorCode = default;
            int? errorSeverity = default;
            string errorMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("threatId"u8))
                {
                    threatId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statement"u8))
                {
                    statement = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statementHighlightOffset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statementHighlightOffset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("statementHighlightLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statementHighlightLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorSeverity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorSeverity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SecurityEventSqlInjectionAdditionalProperties(
                threatId,
                statement,
                statementHighlightOffset,
                statementHighlightLength,
                errorCode,
                errorSeverity,
                errorMessage,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ThreatId), out propertyOverride);
            if (Optional.IsDefined(ThreatId) || hasPropertyOverride)
            {
                builder.Append("  threatId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (ThreatId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ThreatId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ThreatId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Statement), out propertyOverride);
            if (Optional.IsDefined(Statement) || hasPropertyOverride)
            {
                builder.Append("  statement: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Statement.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Statement}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Statement}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StatementHighlightOffset), out propertyOverride);
            if (Optional.IsDefined(StatementHighlightOffset) || hasPropertyOverride)
            {
                builder.Append("  statementHighlightOffset: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{StatementHighlightOffset.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StatementHighlightLength), out propertyOverride);
            if (Optional.IsDefined(StatementHighlightLength) || hasPropertyOverride)
            {
                builder.Append("  statementHighlightLength: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{StatementHighlightLength.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ErrorCode), out propertyOverride);
            if (Optional.IsDefined(ErrorCode) || hasPropertyOverride)
            {
                builder.Append("  errorCode: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{ErrorCode.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ErrorSeverity), out propertyOverride);
            if (Optional.IsDefined(ErrorSeverity) || hasPropertyOverride)
            {
                builder.Append("  errorSeverity: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{ErrorSeverity.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ErrorMessage), out propertyOverride);
            if (Optional.IsDefined(ErrorMessage) || hasPropertyOverride)
            {
                builder.Append("  errorMessage: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (ErrorMessage.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ErrorMessage}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ErrorMessage}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityEventSqlInjectionAdditionalProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityEventSqlInjectionAdditionalProperties IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityEventSqlInjectionAdditionalProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityEventSqlInjectionAdditionalProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
