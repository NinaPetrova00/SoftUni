function honk() {
    console.log(this == window);
}

honk();