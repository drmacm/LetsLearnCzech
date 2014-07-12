using LetsLearnCzech.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsLearnCzech.Bll
{
    /// <summary>Bll methods related to <see cref="Word"/>.</summary>
    public class WordBll
    {
        public IList<Word> GetAllWords()
        {
            using (var bll = new BllContext())
            {
                return bll.Words.ToList();
            }
        }

        public IList<Word> GetAllWordsOfType(WordType wordType)
        {
            using (var bll = new BllContext())
            {
                return bll.Words.Where(w => w.WordType == wordType).ToList();
            }
        }

        public IList<Word> GetUnprocessedWordsOfType(WordType wordType)
        {
            using (var bll = new BllContext())
            {
                return bll.Words.Where(w => w.WordType == wordType && w.IsProcessed == false).ToList();
            }
        }

        public Word GetSingleWord(int? id)
        {
            using (var bll = new BllContext())
            {
                return bll.Words.Where(w => w.Id == id.Value).SingleOrDefault();
            }
        }

        public void CreateWord(Word word)
        {
            if (word != null)
            {
                using (var bll = new BllContext())
                {
                    bll.Words.Add(word);
                    bll.SaveChanges();
                }
            }
        }

        public void UpdateWord(Word word)
        {
            using (var bll = new BllContext())
            {
                Word original = bll.Words.Find(word.Id);

                if (original != null)
                {
                    original.ForeignWord = word.ForeignWord;
                    original.LocalWord = word.LocalWord;
                    original.DateModified = DateTime.Now;
                    original.Creator = word.Creator;
                    original.IsProcessed = word.IsProcessed;

                    original.WordType = word.WordType;

                    original.ForeignGender = word.ForeignGender;
                    original.LocalGender = word.LocalGender;
                    original.Case = word.Case;

                    original.Conjugation = word.Conjugation;
                    original.Aspect = word.Aspect;
                    original.Person = word.Person;
                    original.Tense = word.Tense;

                    bll.SaveChanges();
                }
            }
        }

        public void DeleteWord(int? id)
        {
            using (var bll = new BllContext())
            {
                Word word = bll.Words.Where(w => w.Id == id.Value).SingleOrDefault();
                if (word != null)
                {
                    bll.Words.Remove(word);
                    bll.SaveChanges();
                }
            }
        }

    }
}
