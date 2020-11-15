using System;
using System.Collections.Generic;
using System.Text;

namespace UsingJakodevLibs.Mocks
{
    public class WorkingWithEnums
    {
        public Animals Animal {get;set;}
    }

    public enum Animals
    {
        [AnimalSounds("gibber")] apes = 1,
        [AnimalSounds("bray")] asses,
        [AnimalSounds("hum")] bees,
        [AnimalSounds("drone")] beetles,
        [AnimalSounds("growl")] bears,
        [AnimalSounds("boom")] bitterns,
        [AnimalSounds("whistle")] blackbirds,
        [AnimalSounds("we speak of the“chick-chick” of the blackcap")] blackcaps,
        [AnimalSounds("bellow")] bulls,
        [AnimalSounds("grump")] camels,
        [AnimalSounds("sing or quaver")] canaries,
        [AnimalSounds("mew, purr, swear, and caterwaul")] cats,
        [AnimalSounds("bleat and blear")] calves,
        [AnimalSounds("chirp or pink")] chaffinches,
        [AnimalSounds("pip")] chickens,
        [AnimalSounds("sing")] cicadæ,
        [AnimalSounds("crow")] cocks,
        [AnimalSounds("moo or low")] cows,
        [AnimalSounds("caw")] crows,
        [AnimalSounds("cry, cuckoo")] cuckoos,
        [AnimalSounds("bell")] deer,
        [AnimalSounds("click")] dolphins,
        [AnimalSounds("bray")] donkeys,
        [AnimalSounds("bark, bay, howl, and yelp")] dogs,
        [AnimalSounds("coo")] doves,
        [AnimalSounds("quack")] ducks,
        [AnimalSounds("scream")] eagles,
        [AnimalSounds("trumpet")] elephants,
        [AnimalSounds("chant")] falcons,
        [AnimalSounds("buzz")] flies,
        [AnimalSounds("bark and yelp")] foxes,
        [AnimalSounds("croak")] frogs,
        [AnimalSounds("cackle and hiss")] geese,
        [AnimalSounds("we speak of the “merry twinkle” of the female")] goldfinch,
        [AnimalSounds("chirp and pitter")] grasshoppers,
        [AnimalSounds("we speak of the “drumming” of the grouse")] grouse,
        [AnimalSounds("cry “come back”")] guineafowls,
        [AnimalSounds("squeak")] guineapigs,
        [AnimalSounds("squeak")] hares,
        [AnimalSounds("scream")] hawks,
        [AnimalSounds("cackle and cluck")] hens,
        [AnimalSounds("neigh and whinny")] horses,
        [AnimalSounds("laugh")] hyenas,
        [AnimalSounds("howl")] jackals,
        [AnimalSounds("chatter")] jays,
        [AnimalSounds("mew")] kittens,
        [AnimalSounds("baa and bleat")] lambs,
        [AnimalSounds("sing")] larks,
        [AnimalSounds("chuckle in their call")] linnets,
        [AnimalSounds("roar")] lions,
        [AnimalSounds("chatter")] magpies,
        [AnimalSounds("squeak and squeal")] mice,
        [AnimalSounds("chatter and gibber")] monkeys,
        [AnimalSounds("pipe and warble")] nightingales,
        [AnimalSounds("hoot and screech")] owls,
        [AnimalSounds("low and bellow")] oxen,
        [AnimalSounds("talk")] parrots,
        [AnimalSounds("scream")] peacocks,
        [AnimalSounds("coo")] pigeons,
        [AnimalSounds("grunt, squeak, and squeal")] pigs,
        [AnimalSounds("yelp")] puppies,
        [AnimalSounds("chitter")] raccoons,
        [AnimalSounds("croak")] ravens,
        [AnimalSounds("chirp")] robins,
        [AnimalSounds("whistle")] redstarts,
        [AnimalSounds("caw")] rooks,
        [AnimalSounds("screech or shriek")] screech_owls,
        [AnimalSounds("baa or bleat")] sheep,
        [AnimalSounds("hiss")] snakes,
        [AnimalSounds("chirp or yelp")] sparrows,
        [AnimalSounds("bellow and call")] stags,
        [AnimalSounds("twitter")] swallows,
        [AnimalSounds("cry")] swans,
        [AnimalSounds("whistle")] thrushes,
        [AnimalSounds("growl")] tigers,
        [AnimalSounds("gobble")] turkey_cocks,
        [AnimalSounds("scream")] vultures,
        [AnimalSounds("hum")] whales,
        [AnimalSounds("chirr")] whitethroats,
        [AnimalSounds("howl")] wolves,

    }

    public class AnimalSounds : System.Attribute
    {
        private string _valueString;
        public AnimalSounds(string sound)
        {
            _valueString = sound;
        }

        public string Sound
        {
            get
            {
                return _valueString;
            }
            internal set { _valueString = value; }
        }

    }
}
