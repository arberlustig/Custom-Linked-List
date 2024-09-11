

using System.Collections;
using System.Drawing;

//var customCollection = new CustomCollection(
//    new string[] { "aaa", "bbb", "ccc" }
//    );


//foreach( var custom in customCollection )
//    Console.WriteLine(custom);
//var result = new Tuple<();

public class CustomCollection : IEnumerable<string>
{
    public string[] words { get; }

    public CustomCollection(string[] words)
    {
        this.words = words;  
    }

    public string this[int index]
    {
        get => words[index]; 
        set => words[index] = value; 
    }
    
     IEnumerator IEnumerable.GetEnumerator()
    {
        return new WordEnumarator(words);
    }

   public IEnumerator<string> GetEnumerator()
    {
        return new WordEnumarator(words);
    }
}

public class WordEnumarator : IEnumerator<string>
{

    private int _currentPosition = -1;
    private readonly string[] _words;

    public WordEnumarator(string[] words)
    {
        _words = words;
    }


    public object Current => _words[_currentPosition];

    string IEnumerator<string>.Current => throw new NotImplementedException();

    public bool MoveNext()
    {
       _currentPosition++;
        return _currentPosition < _words.Length;
    }

    public void Reset()
    {
       _currentPosition = -1;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}