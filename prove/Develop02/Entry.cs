using System;
using System.Collections.Generic;


namespace Develop02
{
    public class Entry
    {   
        string _prompt = "";
        string _text_entry = "";
        string _current_date = "";J
        public Entry(string: prompt, string: text_entry){
            _prompt = _prompt;
            _text_entry = text_entry;
            DateTime _current_date = DateTime.Now();
        }

        public string EntryToString(){
            return $"{_prompt}{_text_entry}{_current_date}"
        }
    }
}