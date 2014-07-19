using LetsLearnCzech.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LetsLearnCzech.IISService
{
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
        IList<Word> GetUnprocessedWords();

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
