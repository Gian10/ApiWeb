﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ApiTest
{
    // CLASSE DE CABEÇALHO DA SOLICITAÇÃO
    public static class ContentHelper
    {

        public static StringContent GetStringContent(object obj)
            => new StringContent(JsonConvert.SerializeObject(obj), Encoding.Default, "application/json");
    }
}
