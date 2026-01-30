using System;
using System.Collections.Generic;


namespace Develop02
{
    public class Entry
    {   
        string _prompt = "";
        string _textEntry = "";
        DateTime _currentDate = DateTime.Now.Date;
        public Entry(string prompt, string text_entry){
            _prompt = prompt;
            _textEntry = text_entry;
            _currentDate = DateTime.Now.Date;
        }

        public string EntryToString(){
            return $"""{_currentDate}: "{_prompt}" - {_textEntry}""";
        }
    }
}