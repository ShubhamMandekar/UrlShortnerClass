namespace UrlShortnerClass.Service
{
    /// <summary>
    /// Interface Layer for URL services
    /// </summary>
    public interface IUrlShortenerService
    {
        /// <summary>
        /// Method which will perform The shortning of the Long Url Provided
        /// </summary>
        /// <param name="originalUrl"></param>
        /// <returns> Instance of String Indicating Shortened Url for LongUrl </returns>
        Task<string> ShortenUrlAsync(string originalUrl);

        /// <summary>
        /// Method will return valid Long Url for ShortUrl
        /// </summary>
        /// <param name="shortCode"></param>
        /// <returns>Instance of String returning Long url for given short Url</returns>
        Task<string?> GetOriginalUrlAsync(string shortCode);
    }
}
