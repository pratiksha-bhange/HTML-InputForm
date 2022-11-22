.main{
    display: flex;
    flex-direction: column;
    align-items: center;
}

.html,body{
    height: 100%;
    width: 100%;
}

.form-header{
    background-color: coral;
    padding: 1%;
    width: 33%;
    display: flex;
    justify-content: center;
    font-weight: 900;
    font-size: x-large;
}

.form{
    display: flex;
    flex-direction: column;
    height: 600px;
    justify-content: space-around;
    width: 34%;
}
.form-input-type{
    display: flex;
    justify-content: space-between;
}

@media screen and (max-width:540px) {
    .form-header
    {
        width: 100%;
    }

    .form{
        width: 94%;
    }
}
@media screen and (max-width:540px){
    .form{
        height: 532px;
    }
}