using LetsLearnCzech.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LetsLearnCzech.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICzechService
    {
        #region Word
        [WebGet(ResponseFormat=WebMessageFormat.Json, UriTemplate = "GetAllWords")]
        [OperationContract]
        IList<Word> GetAllWords();

        [OperationContract]
        IList<Word> GetAllWordsOfType(WordType wordType);

        [OperationContract]
        IList<Word> GetUnprocessedWordsOfType(WordType wordType);

        [OperationContract]
        Word GetSingleWord(int? id);

        [OperationContract]
        void CreateWord(Word word);

        [OperationContract]
        void UpdateWord(Word word);

        [OperationContract]
        void DeleteWord(int? id);
        #endregion
    }
}
