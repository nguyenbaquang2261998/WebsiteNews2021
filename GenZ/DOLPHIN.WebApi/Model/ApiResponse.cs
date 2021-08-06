using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOLPHIN.WebApi.Enums;
using Newtonsoft.Json;

namespace DOLPHIN.WebApi.Model
{
    public class ApiResponse<T>
    {
        private EnStatusApiReponse success;
        private object p;

        /// <summary>
        /// Initialises a new instance of the <see cref="ApiResponse{T}"/> class.
        /// Initializes a new instance of the <see cref="ApiResponse{T}"/> class.
        /// </summary>
        public ApiResponse()
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ApiResponse{T}"/> class.
        /// Initializes a new instance of the <see cref="ApiResponse{T}"/> class.
        /// </summary>
        /// <param name="success">success.</param>
        public ApiResponse(bool success)
        {
            this.Status = success ? (int)EnStatusApiReponse.Success : (int)EnStatusApiReponse.Error;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ApiResponse{T}"/> class.
        /// Initializes a new instance of the <see cref="ApiResponse{T}"/> class.
        /// </summary>
        /// <param name="apiStatusCode">Enum.ApiStatusCode.</param>
        public ApiResponse(EnStatusApiReponse apiStatusCode)
        {
            this.Status = (int)apiStatusCode;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ApiResponse{T}"/> class.
        /// Initializes a new instance of the <see cref="ApiResponse{T}"/> class.
        /// </summary>
        /// <param name="apiStatusCode">Enum.ApiStatusCode.</param>
        /// <param name="data">Data response.</param>
        public ApiResponse(EnStatusApiReponse apiStatusCode, T data)
        {
            this.Status = (int)apiStatusCode;
            this.Data = data;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ApiResponse{T}"/> class.
        /// Initializes a new instance of the <see cref="ApiResponse{T}"/> class.
        /// </summary>
        /// <param name="messageCode">Message code.</param>
        public ApiResponse(int messageCode)
        {
            this.Status = (int)EnStatusApiReponse.Error;
            this.MessageCode = messageCode;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ApiResponse{T}"/> class.
        /// Initializes a new instance of the <see cref="ApiResponse{T}"/> class.
        /// </summary>
        /// <param name="statusCode">Enum.ApiStatusCode.</param>
        /// <param name="messageCode">Message code.</param>
        /// <param name="data">Data response.</param>
        public ApiResponse(int statusCode, int messageCode, T data)
        {
            this.Status = statusCode;
            this.MessageCode = messageCode;
            this.Data = data;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ApiResponse{T}"/> class.
        /// API Response.
        /// </summary>
        /// <param name="success">success status.</param>
        /// <param name="p">p object.</param>
        public ApiResponse(EnStatusApiReponse success, object p)
        {
            this.success = success;
            this.p = p;
        }

        /// <summary>
        /// Gets or sets status code.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets message code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageCode { get; set; }

        /// <summary>
        /// Gets or sets data response.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public T Data { get; set; }
    }
}
