using Google.Cloud.Firestore;
using System;
using System.IO;

namespace DLL
{
    internal static class FirestoreHelper
    {
        static string fireconfig = @"
        {
            ""type"": ""service_account"",
            ""project_id"": ""mygest-613a7"",
            ""private_key_id"": ""4d1039334657c37d59ea436c4e3beb4b7b7ea6a6"",
            ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQDF7giVjBplJmIk\n2BCJa6c0h7CRXWBYIw0OA1O2GuSVCwFmTMazlYX5Vhdm91cBPNZAM72rzmes68Cj\nuJ74KiPQxyyTRvbB7sUHAjDdd1Qx1hD3z8Mfbxa0C3yrIeMlWZ79nB6CqjJtWepm\ng9ZHhLwaAhw8/sX5Vmv6Cl6rkbcEPSyUt1s67Mvd1T5oMFy2sfrLmptw8jMMXljW\nzH2Ygqq7v902obbi+Cvz5wXB+Aj8HMOcGFDHPzyFlwjtqFT3zFJ0dszf26upyur+\nxgiemoayjePI6OvQcwz3RytIFS4zDCc1p7BnoayXF9mCFbEuXiMz7nNM6JRCxAWb\nLr5SjBwDAgMBAAECgf9AK+ycj8/++3LWfzbdVwne/h9BAgU6jiKtaGa7o/x4Vhke\nEcZacx/8tuzfdVHAFPlh12SnT0RNzCGo8zKXQxJZnjnVhix6s+8tVoiBRS8G+WCG\n99VLW7kAprjEwzfh5CyoDPXXZ1byHTTiB9xxU5eo1wZQwElvjZV0e+g1uAieVqRy\nLRJiGcaVj3x2870FImQxU3bTHCjypPlmjm+Xb7dtDGuZbhHJpSo+Q/cyEvxTkyLR\nCIAzvocA8q7E4UHmWEU9Q8LbY0NgEjQqJBMzfEv+8IQDZhfSy8GrEKGfouQSdVFM\nkv9OEtAXvTRryxYZ9Ex9oCPlYNUsrdPi1nGlEvECgYEA+Fvd89c9EjoSY1laEm3n\nmtzoM5/IvQIaXko+JVo6H/mMvGrBhvRvk7X4UR4keurvF+2olzZqdu2A2HR1u8QL\no4i42K//O4jbEM0n3hI6Rfrc7wzzepiJppLfr/ryinF+4bho7nh8mvMPzb20BlGM\nYcBq08MhLKyHWeRdFDIcKasCgYEAzAT5vAaf0DOwIeuOuWgGyuAllZ4Kqkuj1WXo\nS3McaUFh3gbwoWGIvZkifsi3PKN/hXZlfjzMWmtwmjaw+X8A7ePsN6rGehzSTqvt\nnrK+VNK4oZpLeck3zdP9sLIXzMB5kEL5/OjCAbTVx2rxEPhz/cPwtpqvkRAIOu9e\nhrX47wkCgYEA3wOXRZuUMmbFFkMo132rSGtvctPbLKXTybF/JoljwkyS7KosR6P9\nATWY2jZn6ZxGwETfa5Eofsx8M2I4Sjgbf2iJG8LGPM6CcA7Y6teRTj+a3mnRxNdu\nW45toJeF7X1GwyeVyfWVZoo2ObhMDJRzq19eTfNdOcFe9QBT+IuasGsCgYA860tq\nwoubzqNMLZsrb41/rJhsaYmDuhxMjyZiyRd1smk3s9jMR2ReQMiVFPfp6mQchPLf\nU+YtJaG02pnTlgHABuu035BuTAbcKOhGF9dPWrB4yKq6zcOU+TTqOvNyVxK1adpd\nk17Cxa2D40HiMF3qK0TIMb400ZWzi2AtV07iiQKBgQDRbiAAsO3hmXBG5w22Ir4U\nqjWCtQAuTRjqlJ1Rd5kpoff2R/K84mI13kB3A6oQq7BAi0DV7FrXxe2ExTBUrKed\nDkC27a34VLmoJtVATOB9MX0goFDw6B7covzrX5/Zn5OCuSLw1LC/DDzcqwHrtl9a\nvVLHLuuceufpo7ukEF22sg==\n-----END PRIVATE KEY-----\n"",
            ""client_email"": ""firebase-adminsdk-422kl@mygest-613a7.iam.gserviceaccount.com"",
            ""client_id"": ""114201266967015990272"",
            ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
            ""token_uri"": ""https://oauth2.googleapis.com/token"",
            ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
            ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-422kl%40mygest-613a7.iam.gserviceaccount.com"",
            ""universe_domain"": ""googleapis.com""
        }";

        static string filepath = "";
        public static FirestoreDb? Database { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetTempFileName()) + ".json");
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            Database = FirestoreDb.Create("mygest-613a7");
            File.Delete(filepath); // Eliminar el archivo después de usarlo
        }
    }
}