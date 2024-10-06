using System;

public class Word{
    // Word member variables
    public string _text;
    private bool _isHidden;

    public void Hide(){
        _isHidden = true;
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