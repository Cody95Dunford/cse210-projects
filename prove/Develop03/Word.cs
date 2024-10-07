using System;

public class Word{
    // Word member variables
    private string _text;
    private bool _isHidden;

    public Word(string text){
        _text = text; 
    }

    public void Hide(){
        _isHidden = true;
        _text = GetDisplayText();
    }
    public void Show(){
        _isHidden = false;
    }
    public bool isHidden(){
        return _isHidden;
    }
    public string GetDisplayText(){
        if (_isHidden == true){
            string underscores = "";
            for (int i = 0; i < _text.Length; i++){
                underscores += "_";
            }
            return underscores;
        }
        return _text;
    }
}