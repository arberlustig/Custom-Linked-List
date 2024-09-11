//using System.Linq;



//string[] objekte = { "a", "b", "d", "e", "f" };
//var listeAbNull = GetAllAfterLastNullReversed(objekte);


//IEnumerable<T> GetAllAfterLastNullReversed<T>(IList<T> input)
//{

//    var index = input
//        .Select((item, index) => new { item, index })
//        .Last(objekt => objekt.item is null).index;


//    List<T> result = new List<T>();
//    for (int i = index + 1; i < input.Count; i++)
//        result.Add(input[i]);



//    result.Reverse();
//    return result;
//}
