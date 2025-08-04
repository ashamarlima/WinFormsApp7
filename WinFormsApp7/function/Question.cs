using System;
using System.Collections.Generic;
using System.Linq;

namespace WinFormsApp7
{
    public abstract class Question
    {
        public string QuestionText { get; set; }
  
        public abstract bool CheckAnswer(string userAnswer);
    }

    public class MultipleChoiceQuestion : Question
    {
        public List<string> Options { get; set; }
        public int CorrectOptionIndex { get; set; }

        public override bool CheckAnswer(string userAnswer)
        {
            return userAnswer.Trim().Equals(Options[CorrectOptionIndex], StringComparison.OrdinalIgnoreCase);
        }
    }

    public class OpenEndedQuestion : Question
    {
        public List<string> AcceptableAnswers { get; set; }

        public override bool CheckAnswer(string userAnswer)
        {
            string input = userAnswer.Trim().ToLower();

            foreach (string correct in AcceptableAnswers)
            {
                string cleaned = correct.Trim().ToLower();

                // 1. Exact match
                if (input == cleaned)
                    return true;

                // 2. Acronym match: e.g., "UK" for "United Kingdom"
                string acronym = string.Concat(cleaned
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(word => word[0]));

                if (input == acronym)
                    return true;
            }

            return false;
        }
    }

    public class TrueFalseQuestion : Question
    {
        public bool IsTrue { get; set; }

        public override bool CheckAnswer(string userAnswer)
        {
            return (userAnswer.ToLower() == "true" && IsTrue) || (userAnswer.ToLower() == "false" && !IsTrue);
        }
    }

    public class QuizManager
    {
        public List<Question> Questions { get; set; } = new List<Question>();
        public void AddQuestion(Question q) => Questions.Add(q);
        public void RemoveQuestion(Question q) => Questions.Remove(q);
        public void ClearAll() => Questions.Clear();
    }
}
