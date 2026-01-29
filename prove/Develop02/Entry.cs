using System;
using System.Collections.Generic;


namespace Develop02
{
    public class Entry
    {   
        string _prompt = "";
        string _text_entry = "";
        string _current_date = "";
        public Entry(string prompt, string text_entry){
            _prompt = prompt;
            _text_entry = text_entry;
            DateTime _current_date = DateTime.Now.Date;
        }

        public string EntryToString(){
            return $"{_prompt}{_text_entry}{_current_date}";
        }
    }
}