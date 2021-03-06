// This is my custom license header. I am a nice person so please don't steal
// my code.
//
// Cheers.

namespace AwesomeNamespace.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The access keys for the storage account.
    /// </summary>
    public partial class StorageAccountKeys
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountKeys class.
        /// </summary>
        public StorageAccountKeys()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountKeys class.
        /// </summary>
        /// <param name="key1">Gets the value of key 1.</param>
        /// <param name="key2">Gets the value of key 2.</param>
        public StorageAccountKeys(string key1 = default(string), string key2 = default(string))
        {
            Key1 = key1;
            Key2 = key2;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the value of key 1.
        /// </summary>
        [JsonProperty(PropertyName = "key1")]
        public string Key1 { get; set; }

        /// <summary>
        /// Gets the value of key 2.
        /// </summary>
        [JsonProperty(PropertyName = "key2")]
        public string Key2 { get; set; }

    }
}
