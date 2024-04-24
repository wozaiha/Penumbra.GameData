﻿using static Penumbra.GameData.Enums.GenderRace;

namespace Penumbra.GameData.Enums;

/// <summary> Available character races for players. </summary>
public enum Race : byte
{
    Unknown,
    Hyur,
    Elezen,
    Lalafell,
    Miqote,
    Roegadyn,
    AuRa,
    Hrothgar,
    Viera,
}

/// <summary> Available character genders. </summary>
public enum Gender : byte
{
    Unknown,
    Male,
    Female,
    MaleNpc,
    FemaleNpc,
}

/// <summary> Available model races, which includes Highlanders as a separate model base to Midlanders. </summary>
public enum ModelRace : byte
{
    Unknown,
    Midlander,
    Highlander,
    Elezen,
    Lalafell,
    Miqote,
    Roegadyn,
    AuRa,
    Hrothgar,
    Viera,
}

/// <summary> Available sub-races or clans for player characters. </summary>
public enum SubRace : byte
{
    Unknown,
    Midlander,
    Highlander,
    Wildwood,
    Duskwight,
    Plainsfolk,
    Dunesfolk,
    SeekerOfTheSun,
    KeeperOfTheMoon,
    Seawolf,
    Hellsguard,
    Raen,
    Xaela,
    Helion,
    Lost,
    Rava,
    Veena,
}

/// <summary> The combined gender-race-npc numerical code as used by the game. </summary>
public enum GenderRace : ushort
{
    Unknown             = 0,
    MidlanderMale       = 0101,
    MidlanderMaleNpc    = 0104,
    MidlanderFemale     = 0201,
    MidlanderFemaleNpc  = 0204,
    HighlanderMale      = 0301,
    HighlanderMaleNpc   = 0304,
    HighlanderFemale    = 0401,
    HighlanderFemaleNpc = 0404,
    ElezenMale          = 0501,
    ElezenMaleNpc       = 0504,
    ElezenFemale        = 0601,
    ElezenFemaleNpc     = 0604,
    MiqoteMale          = 0701,
    MiqoteMaleNpc       = 0704,
    MiqoteFemale        = 0801,
    MiqoteFemaleNpc     = 0804,
    RoegadynMale        = 0901,
    RoegadynMaleNpc     = 0904,
    RoegadynFemale      = 1001,
    RoegadynFemaleNpc   = 1004,
    LalafellMale        = 1101,
    LalafellMaleNpc     = 1104,
    LalafellFemale      = 1201,
    LalafellFemaleNpc   = 1204,
    AuRaMale            = 1301,
    AuRaMaleNpc         = 1304,
    AuRaFemale          = 1401,
    AuRaFemaleNpc       = 1404,
    HrothgarMale        = 1501,
    HrothgarMaleNpc     = 1504,
    HrothgarFemale      = 1601,
    HrothgarFemaleNpc   = 1604,
    VieraMale           = 1701,
    VieraMaleNpc        = 1704,
    VieraFemale         = 1801,
    VieraFemaleNpc      = 1804,
    UnknownMaleNpc      = 9104,
    UnknownFemaleNpc    = 9204,
}

public static class RaceEnumExtensions
{
    /// <summary> Convert a ModelRace to a Race, i.e. Midlander and Highlander to Hyur. </summary>
    public static Race ToRace(this ModelRace race)
        => race switch
        {
            ModelRace.Unknown    => Race.Unknown,
            ModelRace.Midlander  => Race.Hyur,
            ModelRace.Highlander => Race.Hyur,
            ModelRace.Elezen     => Race.Elezen,
            ModelRace.Lalafell   => Race.Lalafell,
            ModelRace.Miqote     => Race.Miqote,
            ModelRace.Roegadyn   => Race.Roegadyn,
            ModelRace.AuRa       => Race.AuRa,
            ModelRace.Hrothgar   => Race.Hrothgar,
            ModelRace.Viera      => Race.Viera,
            _                    => Race.Unknown,
        };

    /// <summary> Convert a clan to its race. </summary>
    public static Race ToRace(this SubRace subRace)
        => subRace switch
        {
            SubRace.Unknown         => Race.Unknown,
            SubRace.Midlander       => Race.Hyur,
            SubRace.Highlander      => Race.Hyur,
            SubRace.Wildwood        => Race.Elezen,
            SubRace.Duskwight       => Race.Elezen,
            SubRace.Plainsfolk      => Race.Lalafell,
            SubRace.Dunesfolk       => Race.Lalafell,
            SubRace.SeekerOfTheSun  => Race.Miqote,
            SubRace.KeeperOfTheMoon => Race.Miqote,
            SubRace.Seawolf         => Race.Roegadyn,
            SubRace.Hellsguard      => Race.Roegadyn,
            SubRace.Raen            => Race.AuRa,
            SubRace.Xaela           => Race.AuRa,
            SubRace.Helion          => Race.Hrothgar,
            SubRace.Lost            => Race.Hrothgar,
            SubRace.Rava            => Race.Viera,
            SubRace.Veena           => Race.Viera,
            _                       => Race.Unknown,
        };

    /// <summary> Obtain a human-readable name for a ModelRace. </summary>
    public static string ToName(this ModelRace modelRace)
        => modelRace switch
        {
            ModelRace.Midlander  => SubRace.Midlander.ToName(),
            ModelRace.Highlander => SubRace.Highlander.ToName(),
            ModelRace.Elezen     => Race.Elezen.ToName(),
            ModelRace.Lalafell   => Race.Lalafell.ToName(),
            ModelRace.Miqote     => Race.Miqote.ToName(),
            ModelRace.Roegadyn   => Race.Roegadyn.ToName(),
            ModelRace.AuRa       => Race.AuRa.ToName(),
            ModelRace.Hrothgar   => Race.Hrothgar.ToName(),
            ModelRace.Viera      => Race.Viera.ToName(),
            _                    => Race.Unknown.ToName(),
        };

    /// <summary> Obtain a human-readable name for Race. </summary>
    public static string ToName(this Race race)
        => race switch
        {
            Race.Hyur     => "人族",
            Race.Elezen   => "精灵族",
            Race.Lalafell => "拉拉菲尔族",
            Race.Miqote   => "猫魅族",
            Race.Roegadyn => "鲁加族",
            Race.AuRa     => "敖龙族",
            Race.Hrothgar => "硌狮族",
            Race.Viera    => "维埃拉族",
            _             => "未知",
        };

    /// <summary> Obtain a human-readable name for Gender. </summary>
    public static string ToName(this Gender gender)
        => gender switch
        {
            Gender.Male      => "男性",
            Gender.Female    => "女性",
            Gender.MaleNpc   => "男性NPC",
            Gender.FemaleNpc => "女性NPC",
            _                => "未知",
        };

    /// <summary> Obtain a human-readable name for SubRace. </summary>
    public static string ToName(this SubRace subRace)
        => subRace switch
        {
            SubRace.Midlander       => "中原之民（人族）",
            SubRace.Highlander      => "高地之民（人族）",
            SubRace.Wildwood        => "森林之民（精灵族）",
            SubRace.Duskwight       => "黑影之民（精灵族）",
            SubRace.Plainsfolk      => "平原之民（拉拉菲尔族）",
            SubRace.Dunesfolk       => "沙漠之民（拉拉菲尔族）",
            SubRace.SeekerOfTheSun  => "逐日之民（猫魅族）",
            SubRace.KeeperOfTheMoon => "护月之民（猫魅族）",
            SubRace.Seawolf         => "北洋之民（鲁加族）",
            SubRace.Hellsguard      => "红焰之民（鲁加族）",
            SubRace.Raen            => "晨曦之民（敖龙族）",
            SubRace.Xaela           => "暮晖之民（敖龙族）",
            SubRace.Helion          => "掠日之民（硌狮族）",
            SubRace.Lost            => "迷踪之民（硌狮族）",
            SubRace.Rava            => "密林之民（维埃拉族）",
            SubRace.Veena           => "山林之民（维埃拉族）",
            _                       => "未知",
        };

    /// <summary> Obtain abbreviated names for SubRace. </summary>
    public static string ToShortName(this SubRace subRace)
        => subRace switch
        {
            SubRace.SeekerOfTheSun  => "逐日之民",
            SubRace.KeeperOfTheMoon => "护月之民",
            _                       => subRace.ToName(),
        };

    /// <summary> Check if a clan and race agree. </summary>
    public static bool FitsRace(this SubRace subRace, Race race)
        => subRace.ToRace() == race;

    /// <summary> Reduce render and model race to a single byte. </summary>
    public static byte ToByte(this Gender gender, ModelRace modelRace)
        => (byte)((int)gender | ((int)modelRace << 3));

    /// <inheritdoc cref="ToByte(Gender,ModelRace)"/>
    public static byte ToByte(this ModelRace modelRace, Gender gender)
        => gender.ToByte(modelRace);

    /// <summary> Reduce a combined GenderRace to a single byte instead of two. </summary>
    public static byte ToByte(this GenderRace value)
    {
        var (gender, race) = value.Split();
        return gender.ToByte(race);
    }

    /// <summary> Split a combined GenderRace into its corresponding Gender and ModelRace. </summary>
    public static (Gender, ModelRace) Split(this GenderRace value)
    {
        return value switch
        {
            Unknown             => (Gender.Unknown, ModelRace.Unknown),
            MidlanderMale       => (Gender.Male, ModelRace.Midlander),
            MidlanderMaleNpc    => (Gender.MaleNpc, ModelRace.Midlander),
            MidlanderFemale     => (Gender.Female, ModelRace.Midlander),
            MidlanderFemaleNpc  => (Gender.FemaleNpc, ModelRace.Midlander),
            HighlanderMale      => (Gender.Male, ModelRace.Highlander),
            HighlanderMaleNpc   => (Gender.MaleNpc, ModelRace.Highlander),
            HighlanderFemale    => (Gender.Female, ModelRace.Highlander),
            HighlanderFemaleNpc => (Gender.FemaleNpc, ModelRace.Highlander),
            ElezenMale          => (Gender.Male, ModelRace.Elezen),
            ElezenMaleNpc       => (Gender.MaleNpc, ModelRace.Elezen),
            ElezenFemale        => (Gender.Female, ModelRace.Elezen),
            ElezenFemaleNpc     => (Gender.FemaleNpc, ModelRace.Elezen),
            LalafellMale        => (Gender.Male, ModelRace.Lalafell),
            LalafellMaleNpc     => (Gender.MaleNpc, ModelRace.Lalafell),
            LalafellFemale      => (Gender.Female, ModelRace.Lalafell),
            LalafellFemaleNpc   => (Gender.FemaleNpc, ModelRace.Lalafell),
            MiqoteMale          => (Gender.Male, ModelRace.Miqote),
            MiqoteMaleNpc       => (Gender.MaleNpc, ModelRace.Miqote),
            MiqoteFemale        => (Gender.Female, ModelRace.Miqote),
            MiqoteFemaleNpc     => (Gender.FemaleNpc, ModelRace.Miqote),
            RoegadynMale        => (Gender.Male, ModelRace.Roegadyn),
            RoegadynMaleNpc     => (Gender.MaleNpc, ModelRace.Roegadyn),
            RoegadynFemale      => (Gender.Female, ModelRace.Roegadyn),
            RoegadynFemaleNpc   => (Gender.FemaleNpc, ModelRace.Roegadyn),
            AuRaMale            => (Gender.Male, ModelRace.AuRa),
            AuRaMaleNpc         => (Gender.MaleNpc, ModelRace.AuRa),
            AuRaFemale          => (Gender.Female, ModelRace.AuRa),
            AuRaFemaleNpc       => (Gender.FemaleNpc, ModelRace.AuRa),
            HrothgarMale        => (Gender.Male, ModelRace.Hrothgar),
            HrothgarMaleNpc     => (Gender.MaleNpc, ModelRace.Hrothgar),
            HrothgarFemale      => (Gender.Female, ModelRace.Hrothgar),
            HrothgarFemaleNpc   => (Gender.FemaleNpc, ModelRace.Hrothgar),
            VieraMale           => (Gender.Male, ModelRace.Viera),
            VieraMaleNpc        => (Gender.Male, ModelRace.Viera),
            VieraFemale         => (Gender.Female, ModelRace.Viera),
            VieraFemaleNpc      => (Gender.FemaleNpc, ModelRace.Viera),
            UnknownMaleNpc      => (Gender.MaleNpc, ModelRace.Unknown),
            UnknownFemaleNpc    => (Gender.FemaleNpc, ModelRace.Unknown),
            _                   => (Gender.Unknown, ModelRace.Unknown),
        };
    }

    /// <summary> Check if a GenderRace code is valid. </summary>
    public static bool IsValid(this GenderRace value)
        => value != Unknown && Enum.IsDefined(typeof(GenderRace), value);

    /// <summary> Obtain the padded race code as used in file paths for a combined GenderRace. </summary>
    public static string ToRaceCode(this GenderRace value)
        => value switch
        {
            MidlanderMale       => "0101",
            MidlanderMaleNpc    => "0104",
            MidlanderFemale     => "0201",
            MidlanderFemaleNpc  => "0204",
            HighlanderMale      => "0301",
            HighlanderMaleNpc   => "0304",
            HighlanderFemale    => "0401",
            HighlanderFemaleNpc => "0404",
            ElezenMale          => "0501",
            ElezenMaleNpc       => "0504",
            ElezenFemale        => "0601",
            ElezenFemaleNpc     => "0604",
            MiqoteMale          => "0701",
            MiqoteMaleNpc       => "0704",
            MiqoteFemale        => "0801",
            MiqoteFemaleNpc     => "0804",
            RoegadynMale        => "0901",
            RoegadynMaleNpc     => "0904",
            RoegadynFemale      => "1001",
            RoegadynFemaleNpc   => "1004",
            LalafellMale        => "1101",
            LalafellMaleNpc     => "1104",
            LalafellFemale      => "1201",
            LalafellFemaleNpc   => "1204",
            AuRaMale            => "1301",
            AuRaMaleNpc         => "1304",
            AuRaFemale          => "1401",
            AuRaFemaleNpc       => "1404",
            HrothgarMale        => "1501",
            HrothgarMaleNpc     => "1504",
            HrothgarFemale      => "1601",
            HrothgarFemaleNpc   => "1604",
            VieraMale           => "1701",
            VieraMaleNpc        => "1704",
            VieraFemale         => "1801",
            VieraFemaleNpc      => "1804",
            UnknownMaleNpc      => "9104",
            UnknownFemaleNpc    => "9204",
            _                   => string.Empty,
        };

    /// <summary> Obtain the fallback model for a combined gender and race. </summary>
    public static GenderRace Fallback(this GenderRace raceCode)
    {
        var female = (((ushort)raceCode / 100) & 1) == 0;
        var child  = (ushort)raceCode % 10 == 4;
        return raceCode switch
        {
            MidlanderMaleNpc or MidlanderFemale                    => MidlanderMale,
            RoegadynMaleNpc or HrothgarMale                        => RoegadynMale,
            LalafellMaleNpc or LalafellFemale or LalafellFemaleNpc => LalafellMale,
            AuRaMaleNpc or AuRaFemaleNpc                           => AuRaMale,
            _ when child                                           => MidlanderMaleNpc,
            _ when female                                          => MidlanderFemale,
            _                                                      => MidlanderMale,
        };
    }

    /// <summary> Enumerate all fallbacks for a given combined gender and race in order of the dependency tree upwards. </summary>
    public static IEnumerable<GenderRace> Dependencies(this GenderRace raceCode)
    {
        var currentRace = raceCode;
        while (currentRace != MidlanderMale)
        {
            yield return currentRace;
            currentRace = currentRace.Fallback();
        }
        yield return MidlanderMale;
    }

    /// <summary> Enumerate all fallbacks for a given combined gender and race in order of the dependency tree upwards, but skip . </summary>
    public static IEnumerable<GenderRace> OnlyDependencies(this GenderRace raceCode)
        => raceCode.Dependencies().Skip(1);
}

public static partial class Names
{
    /// <summary> Convert a given padded race code from a file path to its combined GenderRace. </summary>
    public static GenderRace GenderRaceFromCode(string code)
        => code switch
        {
            "0101" => MidlanderMale,
            "0104" => MidlanderMaleNpc,
            "0201" => MidlanderFemale,
            "0204" => MidlanderFemaleNpc,
            "0301" => HighlanderMale,
            "0304" => HighlanderMaleNpc,
            "0401" => HighlanderFemale,
            "0404" => HighlanderFemaleNpc,
            "0501" => ElezenMale,
            "0504" => ElezenMaleNpc,
            "0601" => ElezenFemale,
            "0604" => ElezenFemaleNpc,
            "0701" => MiqoteMale,
            "0704" => MiqoteMaleNpc,
            "0801" => MiqoteFemale,
            "0804" => MiqoteFemaleNpc,
            "0901" => RoegadynMale,
            "0904" => RoegadynMaleNpc,
            "1001" => RoegadynFemale,
            "1004" => RoegadynFemaleNpc,
            "1101" => LalafellMale,
            "1104" => LalafellMaleNpc,
            "1201" => LalafellFemale,
            "1204" => LalafellFemaleNpc,
            "1301" => AuRaMale,
            "1304" => AuRaMaleNpc,
            "1401" => AuRaFemale,
            "1404" => AuRaFemaleNpc,
            "1501" => HrothgarMale,
            "1504" => HrothgarMaleNpc,
            "1601" => HrothgarFemale,
            "1604" => HrothgarFemaleNpc,
            "1701" => VieraMale,
            "1704" => VieraMaleNpc,
            "1801" => VieraFemale,
            "1804" => VieraFemaleNpc,
            "9104" => UnknownMaleNpc,
            "9204" => UnknownFemaleNpc,
            _      => Unknown,
        };

    /// <summary> Obtain a combined GenderRace code from a reduced single byte. </summary>
    public static GenderRace GenderRaceFromByte(byte value)
    {
        var gender = (Gender)(value & 0b111);
        var race   = (ModelRace)(value >> 3);
        return CombinedRace(gender, race);
    }

    /// <summary> Combine a Gender and a ModelRace to a combined GenderRace. </summary>
    public static GenderRace CombinedRace(Gender gender, ModelRace modelRace)
    {
        return gender switch
        {
            Gender.Male => modelRace switch
            {
                ModelRace.Midlander  => MidlanderMale,
                ModelRace.Highlander => HighlanderMale,
                ModelRace.Elezen     => ElezenMale,
                ModelRace.Lalafell   => LalafellMale,
                ModelRace.Miqote     => MiqoteMale,
                ModelRace.Roegadyn   => RoegadynMale,
                ModelRace.AuRa       => AuRaMale,
                ModelRace.Hrothgar   => HrothgarMale,
                ModelRace.Viera      => VieraMale,
                _                    => Unknown,
            },
            Gender.MaleNpc => modelRace switch
            {
                ModelRace.Midlander  => MidlanderMaleNpc,
                ModelRace.Highlander => HighlanderMaleNpc,
                ModelRace.Elezen     => ElezenMaleNpc,
                ModelRace.Lalafell   => LalafellMaleNpc,
                ModelRace.Miqote     => MiqoteMaleNpc,
                ModelRace.Roegadyn   => RoegadynMaleNpc,
                ModelRace.AuRa       => AuRaMaleNpc,
                ModelRace.Hrothgar   => HrothgarMaleNpc,
                ModelRace.Viera      => VieraMaleNpc,
                _                    => Unknown,
            },
            Gender.Female => modelRace switch
            {
                ModelRace.Midlander  => MidlanderFemale,
                ModelRace.Highlander => HighlanderFemale,
                ModelRace.Elezen     => ElezenFemale,
                ModelRace.Lalafell   => LalafellFemale,
                ModelRace.Miqote     => MiqoteFemale,
                ModelRace.Roegadyn   => RoegadynFemale,
                ModelRace.AuRa       => AuRaFemale,
                ModelRace.Hrothgar   => HrothgarFemale,
                ModelRace.Viera      => VieraFemale,
                _                    => Unknown,
            },
            Gender.FemaleNpc => modelRace switch
            {
                ModelRace.Midlander  => MidlanderFemaleNpc,
                ModelRace.Highlander => HighlanderFemaleNpc,
                ModelRace.Elezen     => ElezenFemaleNpc,
                ModelRace.Lalafell   => LalafellFemaleNpc,
                ModelRace.Miqote     => MiqoteFemaleNpc,
                ModelRace.Roegadyn   => RoegadynFemaleNpc,
                ModelRace.AuRa       => AuRaFemaleNpc,
                ModelRace.Hrothgar   => HrothgarFemaleNpc,
                ModelRace.Viera      => VieraFemaleNpc,
                _                    => Unknown,
            },
            _ => Unknown,
        };
    }
}
