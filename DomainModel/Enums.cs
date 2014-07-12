using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsLearnCzech.DomainModel
{
    public enum WordType
    {
        Noun = 1,
        Verb = 2
    }

    public enum Gender
    {
        Unknown = 0,
        M = 1,
        F = 2,
        N = 3
    }

    public enum Case
    {
        Unknown = 0,
        Nominative = 1,
        Genitive = 2,
        Dative = 3,
        Accusative = 4,
        Vocative = 5,
        Locative = 6,
        Instrumental = 7
    }

    public enum Conjugation
    {
        Unknown = 0,
        AT = 1,
        OVAT = 2,
        IT = 3,
        Special = 4
    }

    public enum Aspect
    {
        Unknown = 0,
        Perfective = 1,
        Imperfective = 2
    }
     
    public enum Person
    {
        Unknown = 0,
        Infinitive = 1,
        FirstPersonSingular = 2,
        SecondPersonSingular = 3,
        ThirdPersonSingular = 4,
        FirstPersonPlural = 5,
        SecondPersonPlural = 6,
        ThirdPersonPlural = 7
    }

    public enum Tense
    {
        Unknown = 0,
        Infinitive = 1,
        Present = 2,
        Past = 3,
        Future = 4,
    }
}
