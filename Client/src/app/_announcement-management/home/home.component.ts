import { Component, OnInit } from "@angular/core";

@Component({
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
    value: number = 0

    ngOnInit(): void {
        this.value = + localStorage.getItem('value');
    }
      
    isCar() {
        this.value = 0
        localStorage.setItem('value', '0');
    }    

    isMotorcycle() {
        this.value = 1
        localStorage.setItem('value', '1');
    }

    isTruck() {
        this.value = 2
        localStorage.setItem('value', '2');
    }

    isVan() {
        this.value = 3
        localStorage.setItem('value', '3');
    }

    isTrailer() {
        this.value = 4
        localStorage.setItem('value', '4');
    }
}