using LetsLearnCzech.Bll;
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
    public class CzechService : ICzechService
    {
        private readonly WordBll wordBll;
        private readonly UserBll userBll;

        public CzechService()
        {
            wordBll = new WordBll();
            userBll = new UserBll();
        }

        public IList<Word> GetAllWords()
        {
            return wordBll.GetAllWords();
        }

        public IList<Word> GetAllWordsOfType(WordType wordType)
        {
            return wordBll.GetAllWordsOfType(wordType);
        }

        public IList<Word> GetUnprocessedWords()
        {
            return wordBll.GetUnprocessedWords();
        }

        public Word GetSingleWord(int? id)
        {
            return wordBll.GetSingleWord(id);
        }

        public void CreateWord(Word word)
        {
            wordBll.CreateWord(word);
        }

        public void UpdateWord(Word word)
        {
            wordBll.UpdateWord(word);
        }

        public void DeleteWord(int? id)
        {
            wordBll.DeleteWord(id);
        }
    }
}
