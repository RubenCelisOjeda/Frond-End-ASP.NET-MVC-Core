﻿namespace AppProductBooking.Util
{
    public class BaseResponse<T>
    {
        /// <summary>
        /// Codigo de error
        /// </summary>
        public string CodigoError { get; set; }

        /// <summary>
        /// Data de la respuesta
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Respuesta
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Mensaje de la respuesta
        /// </summary>
        public string Message { get; set; }
    }
}
