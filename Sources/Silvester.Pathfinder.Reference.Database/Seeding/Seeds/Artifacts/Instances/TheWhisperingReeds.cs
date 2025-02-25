using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Artifacts.Instances
{
    public class TheWhisperingReeds : Template
    {
        public static readonly Guid ID = Guid.Parse("5b4598fe-c510-4e2c-9e47-937c9c8ec06b");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "The Whispering Reeds",
                Destruction = "Copies of The Whispering Reeds have no special protections and can be destroyed like any regular book, but doing so exposes the one who destroyed the book to the Empty Death.",
                Usage = "Held in 2 hands.",
                ItemLevel = 10,
                BulkId = Bulks.Instances.TwoBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7c19c1a8-a09a-49f5-956a-1e8e8ec8ba54"), Type = TextBlockType.Text, Text = "This hefty tome was compiled centuries ago by an anonymous author who sought to collect all parables, myths, stories, and encounters with the Outer Goddess Nhimbaloth. According to the introduction, the author's original intent was to create a work that foes of the Empty Death could use to fight against her influence, but as one reads through the book, it becomes apparent that the opposite effect has been achieved—by compiling these stories, the author inadvertently generated a work that made it easier for Nhimbaloth to influence the world. Those who venerate the Empty Death seek copies of this book to use as a guide and religious text, while those who don't know better and peruse the book as though it were merely an anthology of stories find themselves unwittingly falling prey to Nhimbaloth's cult or agents of the entity herself. Those who study from The Whispering Reeds for too long are often cursed to rise as ghosts after death— though their existence never lasts for long, as they are inevitably consumed by Nhimbaloth." };
            yield return new TextBlock { Id = Guid.Parse("c46e7bb5-b68d-4c4b-b916-ea45c36d80e9"), Type = TextBlockType.Text, Text = "If a character understands the dangers of this book, however, moderated use can stall or even prevent such a fate from befalling them. If a character takes special care, they can even potentially use The Whispering Reeds for its original purpose—as a weapon against the cult of Nhimbaloth. Using the text too often or leveraging some of its more powerful effects, however, causes the user to feel an ominous chill. In these cases, the user is exposed to the tome's curse, Empty Death (see below)." };
            yield return new TextBlock { Id = Guid.Parse("e4a13b45-ca83-445d-a62a-159de8bad762"), Type = TextBlockType.Text, Text = "The anonymous compiler wanted to produce an enormous print run of The Whispering Reeds, but after the initial run they realized the danger and scuttled those plans, instead attempting to destroy those copies already created. This crusade caught the attention of Nhimbaloth's cult, who swiftly assassinated the compiler. Fewer than two dozen copies of this rare tome are believed to still exist. The book's sinister nature causes all attempts to transcribe it to fail, resulting in bodies of gibberish, nonsense text." };
            yield return new TextBlock { Id = Guid.Parse("d0975e36-96e2-4c27-b2a7-de8294c85386"), Type = TextBlockType.Text, Text = "The Whispering Reeds provides several abilities, but you can't activate any of them while you are stupefied unless you are a follower of Nhimbaloth." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("fc118b2f-6e83-455c-a62d-84f60f75494a"),
                Name = "Investigate",
                RequiredTime = "10 minutes.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("1aa4e733-dd23-4d1b-822c-327925bbd71c"), Type = TextBlockType.Text, Text = "You gain a +2 item bonus to skill checks to Recall Knowledge about Nhimbaloth, her faith, or creatures associated with her (such as incorporeal undead, vampiric mists, wisps, and other incorporeal creatures associated with death). Each time you use this ability after the first in a 24-hour period, you are exposed to the Empty Death." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("0cc9bab7-3eac-48b4-861b-b2f16dba1c35"),
                Name = "Command, Interact",
                Frequency = "Once per hour.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("cfd6b0f5-8be5-4aa7-97db-fd75d788e395"), Type = TextBlockType.Text, Text = "You read aloud a phrase from the book and target a single incorporeal undead creature within 30 feet. That undead creature takes 5d6 positive damage (DC 27 basic Will save) as portions of their incorporeal being are consumed in patches of seven equally spaced holes. Each time you use this ability after the first in a 24-hour period, you are exposed to the Empty Death." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("47ae5fbf-8621-4e6b-84d4-3c98c7387f98"),
                Name = "Command, Interact",
                Frequency = "Once per day.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("1b3870c8-1ba5-4967-bb98-4580cc1deed3"), Type = TextBlockType.Text, Text = "You invoke a tale from The Whispering Reeds that parallels the situation, environment, or creatures nearby. Eerie mists and indistinct whispers rise in a 20-foot emanation around you, and clusters of seven perfectly spaced divots manifest in the ground, vegetation, and flesh of creatures in the emanation other than yourself and up to three creatures you designate at the time of activation. Creatures afflicted with these divots suffer from agonizing mental anguish in the form of crippling despair and take 4d6 mental damage (DC 27 basic Will save). The mists, whispers, and strange divots fade away at the end of the round, but any creature that takes mental damage from the effect also takes a –1 penalty to saving throws against effects with the emotion trait for 1 minute. You are exposed to the Empty Death each time you use this ability." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("fe8ae67c-a86f-4445-941b-0a226c0ddea2"),
                Name = "Cast a Spell",
                Frequency = "Three times per day.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("f86702a2-4d68-4b27-ac92-f96ef4bbc3a9"), Type = TextBlockType.Text, Text = "You cast one of the following spells at the lowest level possible (unless otherwise specified): crushing despair (one target within 30 feet only), fear (3rd), paranoia, or phantasmal killer. You are exposed to the Empty Death each time you use this ability." }
                }
            };
        }

        protected override IEnumerable<ArtifactDestructionEffect> GetDestructionEffects()
        {
            yield return new ArtifactDestructionEffect
            {
                Id = Guid.Parse("7250a5b4-b24e-4734-a020-a136de5a2a20"),
                Name = "Empty Death",
                DifficultyCheck = 27,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("cd9d0ec6-9e38-4e81-bd9e-fad42feb6432"), Type = TextBlockType.Text, Text = " If you activate The Whispering Reeds and are not a worshipper of Nhimbaloth, you become stupefied 2 for 24 hours as your thoughts fill with paranoia that something is watching you from the other side of death. If you die while affected by the Empty Death, you immediately become a chaotic evil ghost. Every 7 days that pass after you become a ghost, you must succeed at a DC 2 flat check— failure indicates that you are consumed by Nhimbaloth. A creature whose ghost is consumed in this way does not travel to the River of Souls and is utterly annihilated; this creature can only be restored to life via a 10th-level spell effect or ritual like wish."}
                }
            };
        }
        
        protected override IEnumerable<Guid> GetDestructionEffectTraits(ArtifactDestructionEffect effect)
        {
            yield return Traits.Instances.Curse.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Occult.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Occult.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba59ed8d-5861-46d5-ac39-19524a2557f2"),
                SourceId = Sources.Instances.Pathfinder163.ID,
                Page = 78
            };
        }
    }
}
