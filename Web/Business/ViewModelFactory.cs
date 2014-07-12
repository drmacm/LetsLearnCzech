using LetsLearnCzech.Web.CzechService;
using LetsLearnCzech.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsLearnCzech.Web.Business
{
    public class ViewModelFactory
    {
        public static WordModel GetViewModel(Word word)
        {
            if (word == null)
                return null;

            switch (word.WordType)
            { 
                case WordType.Noun:
                    NounModel noun = new NounModel()
                    {
                        Id = word.Id,
                        ForeignWord = word.ForeignWord,
                        LocalWord = word.LocalWord,
                        IsProcessed = word.IsProcessed,
                        DateModified = word.DateModified.Value,
                    };

                    if (word.Case.HasValue)
                            noun.Case = word.Case.Value;
                    if (word.ForeignGender.HasValue)
                            noun.ForeignGender = word.ForeignGender.Value;
                    if (word.LocalGender.HasValue)
                            noun.LocalGender = word.LocalGender.Value;

                    return noun;
                case WordType.Verb:
                    VerbModel verb = new VerbModel()
                    {
                        Id = word.Id,
                        ForeignWord = word.ForeignWord,
                        LocalWord = word.LocalWord,
                        IsProcessed = word.IsProcessed,
                        DateModified = word.DateModified.Value,
                    };
                    if (word.Aspect.HasValue)
                        verb.Aspect = word.Aspect.Value;
                    if (word.Conjugation.HasValue)
                        verb.Conjugation = word.Conjugation.Value;
                    if (word.Person.HasValue)
                        verb.Person = word.Person.Value;
                    if (word.Tense.HasValue)
                        verb.Tense = word.Tense.Value;

                    return verb;
                default:
                    return null;
            }
        }

        public static WordModel GetEmptyViewModel(WordType wordType)
        {
            switch (wordType)
            {
                case WordType.Noun:
                    NounModel noun = new NounModel()
                    {
                        LocalGender = Gender.Unknown,
                        ForeignGender = Gender.Unknown,
                        Case = Case.Unknown
                    };
                    return noun;
                case WordType.Verb:
                    VerbModel verb = new VerbModel()
                    {
                        //Aspect = Aspect.Unknown,
                        //Conjugation = Conjugation.Unknown,
                        //Person = Person.Unknown,
                        //Tense = Tense.Unknown
                    };
                    return verb;
                default:
                    return null;
            }
        }

        public static Word CreateWordFromNoun(NounModel noun)
        {
            if (noun == null) return null;

            Word word = new Word()
            {
                Id = noun.Id,
                Case = noun.Case,
                ForeignGender = noun.ForeignGender,
                ForeignWord = noun.ForeignWord,
                DateModified = DateTime.Now,
                IsProcessed = noun.IsProcessed,
                LocalGender = noun.LocalGender,
                LocalWord = noun.LocalWord,
                WordType = WordType.Noun
            };

            return word;
        }

        public static Word CreateWordFromVerb(VerbModel verb)
        {
            if (verb == null) return null;

            Word word = new Word()
            {
                Id = verb.Id,
                Aspect = verb.Aspect,
                Conjugation = verb.Conjugation,
                ForeignWord = verb.ForeignWord,
                DateModified = DateTime.Now,
                IsProcessed = verb.IsProcessed,
                LocalWord = verb.LocalWord,
                Person = verb.Person,
                Tense = verb.Tense,
                WordType = WordType.Verb
            };

            return word;
        }

    }
}