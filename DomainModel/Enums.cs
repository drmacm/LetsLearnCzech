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
        Unknown = 1,
        M = 2,
        F = 3,
        N = 4
    }

    public enum Case
    {
        Unknown = 1,
        Nominative = 2,
        Genitive = 3,
        Dative = 4,
        Accusative = 5,
        Vocative = 6,
        Locative = 7,
        Instrumental = 8
    }

    public enum Conjugation
    {
        Unknown = 1,
        AT = 2,
        OVAT = 3,
        IT = 4,
        Special = 5
    }

    public enum Aspect
    {
        Unknown = 1,
        Perfective = 2,
        Imperfective = 3
    }
     
    public enum Person
    {
        Unknown = 1,
        Infinitive = 2,
        FirstPersonSingular = 3,
        SecondPersonSingular = 4,
        ThirdPersonSingular = 5,
        FirstPersonPlural = 6,
        SecondPersonPlural = 7,
        ThirdPersonPlural = 8
    }

    public enum Tense
    {
        Unknown = 1,
        Infinitive = 2,
        Present = 3,
        Past = 4,
        Future = 5,
    }
}
