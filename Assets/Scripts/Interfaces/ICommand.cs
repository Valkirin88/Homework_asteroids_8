using UnityEngine;

namespace SpacePatterns
{
    public interface ICommand
    {
        bool Succeeded { get; }
        bool Execute(Transform box);
        void Undo(Transform box);
    }
}
