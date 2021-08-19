using System;

public class Training : Entity
{
    private Lesson[] _lessons = new Lesson[0];

    public void Add(Lesson lesson)
    {
        if (lesson == null)
        {
            return;
        }

        Array.Resize(ref _lessons, _lessons.Length + 1);
        _lessons[^1] = lesson;
    }

    public bool IsPractical()
    {
        if (_lessons.Length == 0)
        {
            return false;
        }

        foreach (var lesson in _lessons)
        {
            if (!(lesson is Practice))
            {
                return false;
            }
        }

        return true;
    }

    public Training Clone()
    {
        var training = new Training();
        foreach (var lesson in _lessons)
        {
            training.Add(lesson.Clone());
        }

        return training;
    }
}