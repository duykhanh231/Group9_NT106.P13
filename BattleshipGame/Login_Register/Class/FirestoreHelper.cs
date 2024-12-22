using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Login_Register.Class
{
    internal static class FirestoreHelper
    {
        static string fireconfig = @"{
  ""type"": ""service_account"",
  ""project_id"": ""baibattleship"",
  ""private_key_id"": ""d9b3d65d31451056b5b2b2464ef188b08110669e"",
  ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQCr6b6dDgjiafsv\nUC3ze6ytYO8hGVNBWSimBRZ2ldCEM/qyIeRPHA/LO3Ez2ntgVetVgTiDGYx0KA1p\nNlApwqsiNOFo/H/fS8PtRsjLI/zpeYM6bhn9+r5/25lJ/LpRIISkYCGoOJeZjkAi\nuRziuIH7dFU492vczcKgT1xonGt6cUpOnuxWzx7LCoclVxL7iC72I/QoV3fgjAAh\nhxN6E2Djm/o32Gcafp+9Ca+Ta+gAIfUtkuSw+ruO9WR4kDdZPGYDeiTV8ItN97Sj\nDGafjQprdHFZwcWzstgqZAEWCpjIgIdby8NzcL61gL3f8FPUaSiEyNQE6gMIUldz\n6AzWcF0tAgMBAAECggEAAzmqBxQSlBklIV8AeI17wwrPoI3OnZfZ4A6j4O0r0/xE\n80FiBdXJsRFxUW76OqejJb/Xs/iGM06vM7oVPUmdyayJqV1AyZ2RT8QMKrIQL4i8\nLsmgzUe1QypSk16Y19S6dOgEqH1kvm+DvXMH1qrt/+4Y1oBxi8j7dJq1ILoFHAqv\ngVJpWg3INh1f+wlUUbe94sDGATs4NwIaJk/2HEpyvoJFkQVkIioiUl5r8huJXw7l\n2zH9OyKcPAxANgru3pprKuJtD8rt7ahRdxYkjcffsy+Un9vaA3MdL7EH48vJoP4w\ne/QNn6U3wNTy1EoDi1oLHX7tdi72KocmtkR5OOquYQKBgQDstBfXpW+dVn61bZPJ\nmk7TjTLVz8/FD4UZNkdhhspYjAdtZ3ragpYK+4jJjtj3SvEsvECNAp9mPKrrWDvo\nYPJ4qX8OAuD6qowtD2Yd4NmQ/Pf1NJO+Z9KMDxmXqcpjefQh8Pquaa+wlWyRTa/z\nsaKlrKBQazOGwgmoVzbBO/T3DQKBgQC57YBUdsdxeXNqqHoMr0CfcXXMQjCtsLX+\nta+ynJdg8Z8jXLjFm9DzxdUoU4S8AuDN1jGaJ9HxU3gGPPNHeWhKo+XRhvhGIjR4\nVJeGMJlNtdBOXegiWGyG+x1JtuqJ3tC87KY8ErPzoqK71/8yPxLTk5i9bfmqADcR\n9/jW5UV2oQKBgQDLk5SR7oIRUuvFREn/8QvsnJrlE0cBl/iEF4/KzC/Jeh2FNaOO\nvRMovO8HUyk9fqHwNLRb0q6fMnxZztgvYvoHVtekiEtQq0/GDWFpPxI/xaHIrYCI\nGSkXNoFvVCNx7NhQPL6NNO5atBjc23EB6XwWe2Kh56E4PDgsJV49UUC9HQKBgQCy\n5ohYvYHi+g3ITxxBIFB6Gt5SEE5ukl5MG95Xar1uFpAdopZX7jn8lhsollRd5BcT\neEp6Hl6warROrE8aMwPa7iGwnsI+GaOLNToncJPSZmNtRIacpaCnsPDZgRvkVXVc\nlAjQPN7SS2dyf7+aRX6D/r01aKCWp2ZV79iMTkesgQKBgCe96eh/TX1dED+MfsoO\n5bukLVOp2aunMeDQ+6ZvJFDp/yZ9rtVEdHoD4pju5KS2nH9hHktMea7uptl55bqA\nvQHrwRVImNk3q77iopUvASbbKFvICRoykDE+iuPZ/H7OfHtHMW5Hw8q/ZEwiqgnM\nMut2/bF7UwXT/O33uaXMXN99\n-----END PRIVATE KEY-----\n"",
  ""client_email"": ""firebase-adminsdk-kp600@baibattleship.iam.gserviceaccount.com"",
  ""client_id"": ""105558677100562869203"",
  ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
  ""token_uri"": ""https://oauth2.googleapis.com/token"",
  ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
  ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-kp600%40baibattleship.iam.gserviceaccount.com"",
  ""universe_domain"": ""googleapis.com""
}
";
        static string filepath = " ";
        public static FirestoreDb? Database { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".jsong";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            Database = FirestoreDb.Create("baibattleship");
            File.Delete(filepath);
        }
    }
}
