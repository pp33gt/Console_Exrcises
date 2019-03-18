using System.Collections.Generic;
using System.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    public class WellformedValidator
    {
        Stack<char> ParantesisesStack { get; }
        Dictionary<char, char> ParantesisesTypeDictionaryByClosed = new Dictionary<char, char>() { { ')', '(' }, { '}', '{' }, { ']', '[' } };

        public WellformedValidator()
        {
            ParantesisesStack = new Stack<char>();
        }

        public bool TestP(string input)
        {
            foreach (var c in input)
            {
                if (ParantesisesTypeDictionaryByClosed.ContainsValue(c))
                    ParantesisesStack.Push(c);

                else if(ParantesisesStack.Count > 0 && ParantesisesTypeDictionaryByClosed.ContainsKey(c))
                {
                    var value = ParantesisesTypeDictionaryByClosed.First(ch => ch.Key == c).Value;
                    if (ParantesisesStack.Peek() == value)
                        ParantesisesStack.Pop();
                    else
                        return false;
                }
            }

            return ParantesisesStack.Count == 0;
        }

        public bool IsWellFormedParentesises(string stringToValidate)
        {
            var characters = stringToValidate.ToCharArray();
            foreach (var character in characters)
            {
                if (IsParantesis(character, out bool isOpeningParentesis))
                {
                    if (isOpeningParentesis)
                    {
                        ParantesisesStack.Push(character);
                    }
                    else
                    {
                        if (HasCorrespondingParentesisOpenClause(character))
                        {
                            ParantesisesStack.Pop();
                        }
                        else
                        {
                            if(ParantesisesStack.Count == 0)
                            {
                                return false;
                            }
                            ParantesisesStack.Push(character);
                        }
                    }
                }
            }

            if (ParantesisesStack.Count == 0)
            {
                return true;
            }
            return false;
        }

        private bool IsParantesis(char ch, out bool isOpeningParentesis)
        {
            isOpeningParentesis = false;
            if (ParantesisesTypeDictionaryByClosed.ContainsKey(ch))
            {
                return true;
            }
            if (ParantesisesTypeDictionaryByClosed.ContainsValue(ch))
            {
                isOpeningParentesis = true;
                return true;
            }
            return false;
        }

        private bool HasCorrespondingParentesisOpenClause(char closeParantesis)
        {
            if (ParantesisesStack.Count > 0)
            {
                var parantesis = ParantesisesStack.Peek();

                if (ParantesisesTypeDictionaryByClosed.ContainsKey(closeParantesis))
                {
                    var correspondingOpenParentesis = ParantesisesTypeDictionaryByClosed[closeParantesis];
                    if (parantesis == correspondingOpenParentesis)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
