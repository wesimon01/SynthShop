using System;
using System.Collections.Generic;

namespace SynthShopData.Models.Infrastructure
{
    public static class PreconfiguredData
    {
        public static List<CatalogItem> GetPreconfiguredCatalogItems()
        {
            return new List<CatalogItem>()
            {
                new CatalogItem { Id = 1, CatalogTypeId = 1, CatalogManufacturerId = 1, CatalogItemSpecsId = 1, AvailableStock = 2, Description = "Roland flagship synth", Name = "Roland Jupiter 6", Price = 2500M, PictureFileName = "roland_jupiter6.jpg" },
                new CatalogItem { Id = 2, CatalogTypeId = 1, CatalogManufacturerId = 1, CatalogItemSpecsId = 2, AvailableStock = 1, Description = "Roland flagship synth", Name = "Roland Jupiter 8", Price= 10000M, PictureFileName = "roland_jup8.jpg" },
                new CatalogItem { Id = 3, CatalogTypeId = 1, CatalogManufacturerId = 1, CatalogItemSpecsId = 3, AvailableStock = 4, Description = "Classic Roland synth", Name = "Roland Juno 60", Price = 1800M, PictureFileName = "roland_juno60.jpg" },
                new CatalogItem { Id = 11, CatalogTypeId = 1, CatalogManufacturerId = 2, CatalogItemSpecsId = 4, AvailableStock = 1, Description = "Dave Smith synth", Name = "Sequential Prophet 5", Price = 6200M, PictureFileName = "sci_prophet5.jpg" },
                new CatalogItem { Id = 10, CatalogTypeId = 1, CatalogManufacturerId = 3, CatalogItemSpecsId = 5, AvailableStock = 2, Description = "Unique Korg synth design", Name = "Korg Monopoly", Price = 1500M, PictureFileName = "korg_monopoly.jpg" },
                new CatalogItem { Id = 6, CatalogTypeId = 2, CatalogManufacturerId = 3, CatalogItemSpecsId = 6, AvailableStock = 3, Description = "Korg workstation", Name = "Korg Trinity", Price = 800M, PictureFileName = "korg_trinity.jpg" },
                new CatalogItem { Id = 7, CatalogTypeId = 1, CatalogManufacturerId = 4, CatalogItemSpecsId = 7, AvailableStock = 4, Description = "Moog Ensemble keyboard", Name = "Moog Opus 3", Price = 1200M, PictureFileName = "moog_opus3.jpg" },
                new CatalogItem { Id = 8, CatalogTypeId = 1, CatalogManufacturerId = 4, CatalogItemSpecsId = 8, AvailableStock = 2, Description = "First moog synth", Name = "Moog Model D", Price = 3500M, PictureFileName = "moog_minimoog.jpg" },
                new CatalogItem { Id = 9, CatalogTypeId = 1, CatalogManufacturerId = 5, CatalogItemSpecsId = 9, AvailableStock = 10, Description = "Revision of Bass Station I", Name = "Novation BassStation 2", Price = 350M, PictureFileName = "novation_bassstation2.jpg" },
                new CatalogItem { Id = 12, CatalogTypeId = 1, CatalogManufacturerId = 4, CatalogItemSpecsId = 10, AvailableStock = 6, Description = "Semimodular Moog synth", Name = "Moog Prodigy", Price = 1200M, PictureFileName = "moog_prodigy.jpg" },
                new CatalogItem { Id = 4, CatalogTypeId = 3, CatalogManufacturerId = 5, CatalogItemSpecsId = 11, AvailableStock = 30, Description = "New Novation polysynth", Name = "Novation Summit", Price = 1999M, PictureFileName = "novation_summit.jpg" },
                new CatalogItem { Id = 5, CatalogTypeId = 4, CatalogManufacturerId = 6, CatalogItemSpecsId = 12, AvailableStock = 7, Description = "Nord first release", Name = "Nord Lead I", Price = 850M, PictureFileName = "clavia_nord_lead.jpg" },
            };
        }

        public static IEnumerable<CatalogManufacturer> GetPreconfiguredCatalogManufacturers()
        {
            return new List<CatalogManufacturer>()
            {
                new CatalogManufacturer() { Id = 1, Manufacturer = "Roland" },
                new CatalogManufacturer() { Id = 2, Manufacturer = "Sequential" },
                new CatalogManufacturer() { Id = 3, Manufacturer = "Korg" },
                new CatalogManufacturer() { Id = 4, Manufacturer = "Moog" },
                new CatalogManufacturer() { Id = 5, Manufacturer = "Novation" },
                new CatalogManufacturer() { Id = 6, Manufacturer = "Clavia" },
                new CatalogManufacturer() { Id = 7, Manufacturer = "Other" }
            };
        }

        public static IEnumerable<CatalogType> GetPreconfiguredCatalogTypes()
        {
            return new List<CatalogType>()
            {
                new CatalogType() { Id = 1, Type = "Analog"},
                new CatalogType() { Id = 2, Type = "Digital" },
                new CatalogType() { Id = 3, Type = "Hybrid" },
                new CatalogType() { Id = 4, Type = "Analog Modeling" }
            };
        }

        public static IEnumerable<CatalogItemSpecs> GetPreconfiguredCatalogItemSpecs()
        {
            return new List<CatalogItemSpecs>()
            {
                new CatalogItemSpecs() { Id = 1, Polyphony = "6 voices", Oscillators = "2 VCO's per voice (12 oscillators total!)", Lfo = "2 LFO's with 4-waveforms (sine, tri, ramp, random)", Filter = " 24 dB/oct 4-pole lowpass/high pass or 12 dB/oct 2-pole bandpass with their own ADSR envelope", Effects = "None" , Keyboard = " 61 keys", Memory = "48 tones / 32 patches", DateProduced = DateTime.Now.Year },
                new CatalogItemSpecs() { Id = 2, Polyphony = "8 voices", Oscillators = "2 VCO's per voice (16 oscillators's!) switchable between triangle, sawtooth, pulse, and square waves plus noise on OSC 2", Lfo = "", Filter = "Low pass filter with 2-pole (12 dB/oct) and 4-pole (24 dB/oct) modes, Env Mod, LFO MOd, Key Follow. Separate 6 dB/oct high pass filter.", Keyboard = "61 note keyboard", Memory = "64 patches and 8 patch presets", DateProduced = DateTime.Now.Year },
                new CatalogItemSpecs() { Id = 3, Polyphony = "6 voices", Oscillators = "DCO: pulse, saw, and square", Lfo = "rate and delay", Filter = "non-resonant high pass and resonant low pass",  Effects = "None", Keyboard = "61 note keyboard (no velocity or aftertouch)", Memory = "32 patches", DateProduced = DateTime.Now.Year },
                new CatalogItemSpecs() { Id = 4, Polyphony = "5 Voices", Oscillators = "2 Osc per voice, square / pulse / tri / saw", Lfo = "modulates pulse width or pitch", Filter = "24db Lowpass filter with resonance",  Effects = "None", Keyboard = "61 keys", Memory = "40 to 120 patches", DateProduced = DateTime.Now.Year },
                new CatalogItemSpecs() { Id = 5, Polyphony = "4 voices", Oscillators = "4 VCOs: triangle / sawtooth / pulse", Lfo = "2 LFOs w/ individual rates", Filter = "VCF, VCF ADSR",  Effects = "Chord Memory / VCO sync / modulation", Keyboard = "44 keys", Memory = "None", DateProduced = DateTime.Now.Year },
                new CatalogItemSpecs() { Id = 6, Polyphony = "32 voices", Oscillators = "ACCESS (Advanced Combined Control Synthesis System): 24 Mbyte PCM ROM, with 375 different PCM multi-samples and 258 drum samples; 128 Z1 sounds in V3 models", Lfo = "2 LFO's with 4-waveforms (sine, tri, ramp, random)", Filter = "Digital ADSR",  Effects = "Stereo digital multi-effect system - 2 master effects and 8 insert effects simultaneously. 14 effects algorithms for master effect and 100 effects algorithms for insert effect", Keyboard = "61 notes; Pro models: 76 notes; ProX models: 88 notes; All keyboards are sensitive to velocity and aftertouch", Memory = "", DateProduced = DateTime.Now.Year },
                new CatalogItemSpecs() { Id = 7, Polyphony = "Divide down (yes)", Oscillators = "STrings, Brass, Organ", Lfo = "None", Filter = "2 VCFs (brass/strings) Hi/Low/Band pass",  Effects = "Chorus", Keyboard = "49 keys", Memory = "None", DateProduced = DateTime.Now.Year },
                new CatalogItemSpecs() { Id = 8, Polyphony = "Monophonic", Oscillators = "3 VCOs", Lfo = "1 (oscillator used as Lfo)", Filter = "24dB/oct, 4-pole lowpass filter with cutoff, resonance, envelope generator, keyboard tracking",  Effects = "None", Keyboard = "44 Keys, single-trigger, low-note priority", Memory = "None", DateProduced = DateTime.Now.Year },
                new CatalogItemSpecs() { Id = 9, Polyphony = "Monophonic", Oscillators = "2 DCO's with pulse and sawtooth. Can be modulated by env2 or the LFO.", Lfo = "2 LFO (random, triangle, and sawtooth waveforms)", Filter = "2-pole or 4-pole switchable; 12dB resonant low-pass. Can be modulated by env2 or the LFO.",  Effects = "None", Keyboard = "25 velocity sensitive keys (octave up/down buttons over 8 octaves)", Memory = "99 patches", DateProduced = DateTime.Now.Year },
                new CatalogItemSpecs() { Id = 10, Polyphony = "Monophonic", Oscillators = "2 VCO's with sawtooth, triangle, and pulse (narrow/square) waveforms", Lfo = "square or triangle", Filter = "24 dB/oct lowpass w/ cutoff, emphasis, A/D/S envelope", Effects = "None", Keyboard = "32 keys (no velocity or aftertouch)", Memory = "None", DateProduced = DateTime.Now.Year },
                new CatalogItemSpecs() { Id = 11, Polyphony = "16 voices", Oscillators = "3 oscillators per voice - Sine, tri, sawtooth, square / pulse, plus 43 wavetables of 5 waveforms per row", Lfo = "4 LFOs", Filter = "Low-pass / band-pass / high-pass / dual filter (separation of each 12dB filters)", Effects = "analog distortion, 3 chorus types, 16 delays types", Keyboard = "61 keys, fatar semi-weighted", Memory = "Patch storage - up to 512 on hardware (ships with 256 factory patches)", DateProduced = DateTime.Now.Year },
                new CatalogItemSpecs() { Id = 12, Polyphony = "4 to 12 voices, 4 part Multitimbral", Oscillators = "2 VSM oscillators (triangle, sawtooth, pulse) and noise", Lfo = "2 LFO's (triangle, sawtooth, random) control OSC 1 or 2, filter, pulse-width, ADSR envelope", Filter = "12 dB/oct 2-pole lowpass, 24dB/oct 4-pole lowpass / bandpass / highpass (both with cutoff, resonance, env amount, env velocity, key tracking, ADSR envelope)", Effects = "None", Keyboard = "48 velocity sensitive keys", Memory = "59 preset programs, 40 user, 100 performances", DateProduced = DateTime.Now.Year }
            };
        }
    }
}
