using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MOLECULAR BASIS OF LIFE
public class Biology_2_1_QuestionBank : MonoBehaviour
{
    public static List<Question> questions = new List<Question>();
    public static Question Biology_2_1_001, Biology_2_1_002, Biology_2_1_003, Biology_2_1_004, Biology_2_1_005, Biology_2_1_006, Biology_2_1_007, Biology_2_1_008, Biology_2_1_009, Biology_2_1_010, Biology_2_1_011, Biology_2_1_012;

    public string test = "atom";

    void Start()
    {
        Biology_2_1_001 = new Question()
        {
            number = 1,
            questionAudio = "atom",
            answer = "atom",
            answered = false,
            level = 1,
            description = "The smallest unit of an element that still retains the chemical properties of the element."
        };

        Biology_2_1_002 = new Question()
        {
            number = 2,
            questionAudio = "atomic mass",
            answer = "atomic mass",
            answered = false,
            level = 1,
            description = "The mass of an element; approximately equal to the number of protons and neutrons in its nucleus."
        };

        Biology_2_1_003 = new Question()
        {
            number = 3,
            questionAudio = "atomic number",
            answer = "atomic number",
            answered = false,
            level = 1,
            description = "The number of protons in the nucleus of the atom (Note: the number also equals the number of electrons around the nucleus)."
        };

        Biology_2_1_004 = new Question()
        {
            number = 4,
            questionAudio = "compound",
            answer = "compound",
            answered = false,
            level = 1,
            description = "A chemical substance composed of atoms of two or more distinct elements chemically bonded to one another."
        };

        Biology_2_1_005 = new Question()
        {
            number = 5,
            questionAudio = "diatomic",
            answer = "diatomic",
            answered = false,
            level = 1,
            description = "Containing two atoms."
        };

        Biology_2_1_006 = new Question()
        {
            number = 6,
            questionAudio = "electron",
            answer = "electron",
            answered = false,
            level = 1,
            description = "A subatomic particle, fundamental to all matter, existing in orbit around the nucleus of an atom and carries a negative charge."
        };

        Biology_2_1_007 = new Question()
        {
            number = 7,
            questionAudio = "matter",
            answer = "matter",
            answered = false,
            level = 1,
            description = "Anything which occupies space and has mass."
        };

        Biology_2_1_008 = new Question()
        {
            number = 8,
            questionAudio = "mixture",
            answer = "mixture",
            answered = false,
            level = 1,
            description = "Two or more substances mixed together but not chemically combined."
        };

        Biology_2_1_009 = new Question()
        {
            number = 9,
            questionAudio = "molecule",
            answer = "molecule",
            answered = false,
            level = 1,
            description = "A unit of matter representing the chemical properties of a substance composed of two or more atoms held together by chemical bonds."
        };

        Biology_2_1_010 = new Question()
        {
            number = 10,
            questionAudio = "neutron",
            answer = "neutron",
            answered = false,
            level = 1,
            description = "A subatomic particle, fundamental to all matter except hydrogen, existing in the nucleus, with about the same mass as a proton, but carries no charge."
        };

        Biology_2_1_011 = new Question()
        {
            number = 11,
            questionAudio = "nucleus",
            answer = "nucleus",
            answered = false,
            level = 1,
            description = "The positively charged center of an atom which contains both the protons and neutrons of the atom."
        };

        Biology_2_1_012 = new Question()
        {
            number = 12,
            questionAudio = "proton",
            answer = "proton",
            answered = false,
            level = 1,
            description = "A subatomic particle, fundamental to all matter, existing in the nucleus, with a positive charge and about equal mass to a neutron."
        };

        LoadQuestionList();
    }

    public static void LoadQuestionList()
    {
        questions.Add(Biology_2_1_001);
        questions.Add(Biology_2_1_002);
        questions.Add(Biology_2_1_003);
        questions.Add(Biology_2_1_004);
        questions.Add(Biology_2_1_005);
        questions.Add(Biology_2_1_006);
        questions.Add(Biology_2_1_007);
        questions.Add(Biology_2_1_008);
        questions.Add(Biology_2_1_009);
        questions.Add(Biology_2_1_010);
        questions.Add(Biology_2_1_011);
        questions.Add(Biology_2_1_012);

        // questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        // Debug.Log(questions.Count);
    }
}
