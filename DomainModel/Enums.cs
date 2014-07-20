using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LetsLearnCzech.DomainModel
{
    [DataContract]
    public enum WordState
    {
        [EnumMember]
        Unsynchronized = 1,
        [EnumMember]
        Synhronized = 2,
    }
    [DataContract]
    public enum WordType
    {
        [EnumMember]
        Unknown = 1,
        [EnumMember]
        Noun = 2,
        [EnumMember]
        Verb = 3
    }
    [DataContract]
    public enum Gender
    {
        [EnumMember]
        Unknown = 1,
        [EnumMember]
        M = 2,
        [EnumMember]
        F = 3,
        [EnumMember]
        N = 4
    }
    [DataContract]
    public enum Case
    {
        [EnumMember]
        Unknown = 1,
        [EnumMember]
        Nominative = 2,
        [EnumMember]
        Genitive = 3,
        [EnumMember]
        Dative = 4,
        [EnumMember]
        Accusative = 5,
        [EnumMember]
        Vocative = 6,
        [EnumMember]
        Locative = 7,
        [EnumMember]
        Instrumental = 8
    }
    [DataContract]
    public enum Conjugation
    {
        [EnumMember]
        Unknown = 1,
        [EnumMember]
        AT = 2,
        [EnumMember]
        OVAT = 3,
        [EnumMember]
        IT = 4,
        [EnumMember]
        Special = 5
    }
    [DataContract]
    public enum Aspect
    {
        [EnumMember]
        Unknown = 1,
        [EnumMember]
        Perfective = 2,
        [EnumMember]
        Imperfective = 3
    }
    [DataContract]
    public enum Person
    {
        [EnumMember]
        Unknown = 1,
        [EnumMember]
        Infinitive = 2,
        [EnumMember]
        FirstPersonSingular = 3,
        [EnumMember]
        SecondPersonSingular = 4,
        [EnumMember]
        ThirdPersonSingular = 5,
        [EnumMember]
        FirstPersonPlural = 6,
        [EnumMember]
        SecondPersonPlural = 7,
        [EnumMember]
        ThirdPersonPlural = 8
    }
    [DataContract]
    public enum Tense
    {
        [EnumMember]
        Unknown = 1,
        [EnumMember]
        Infinitive = 2,
        [EnumMember]
        Present = 3,
        [EnumMember]
        Past = 4,
        [EnumMember]
        Future = 5,
    }
}
