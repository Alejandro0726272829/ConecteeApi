using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ConecteeApi.Models
{
   public class Servicio
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("usuarioId")]
    public string UsuarioId { get; set; } = null!;

    [BsonElement("descripcion")]
    public string Descripcion { get; set; } = null!;

    [BsonElement("origen")]
    public string Origen { get; set; } = null!;

    [BsonElement("destino")]
    public string Destino { get; set; } = null!;

    [BsonElement("costo")] // 🔥 ¡Este debe existir!
    public decimal Costo { get; set; }

    [BsonElement("estado")]
    public string Estado { get; set; } = null!;

    [BsonElement("fecha")]
    public DateTime Fecha { get; set; }

    [BsonElement("fechaSolicitud")]
    public DateTime FechaSolicitud { get; set; }
}

}

