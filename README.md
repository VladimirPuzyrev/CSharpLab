# CSharpLab

#Задание 1. Есть класс State, который представляет государство:
#class State
#{
#    public decimal Population { get; set; } # население
#    public decimal Area { get; set; }       # территория
#}

#Добавьте в класс оператор сложения, который бы позволял объединять государства.
#А также операторы сравнения<и> для сравнения государств по какому-нибудь критерию (например, по населению или территории). Наподобие
#State state1 = new State();
#State state2 = new State();
#State state3 = state1 + state2;
#bool isGreater = state1 > state2;


# Задание 2. Пусть даны следующие классы:

#class Word
#{
#    public string Source { get; }
#    public string Target { get; set; }
#    public Word(string source, string target)
#    {
#        Source = source;
#        Target = target;
#    }
#}
#class Dictionary
#{
#    Word[] words;
#    public Dictionary()
#    {
#        words = new Word[]
#        {
#            new Word("red", "красный"),
#            new Word("blue", "синий"),
#            new Word("green", "зеленый")
#        };
#    }
#}