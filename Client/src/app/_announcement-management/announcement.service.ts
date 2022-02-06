import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { FormBuilder, FormGroup } from "@angular/forms";

@Injectable({
    providedIn: 'root'
})
export class AnnouncementService {
    constructor(protected http: HttpClient, protected fb: FormBuilder) {
            
    }

    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json'
        })
    }

    readonly BaseURI = 'http://localhost:27563/api';


    createCarAnnouncement(announcementForm: FormGroup) {
        var body = {
            title: announcementForm.value.announcement.title,
            price: announcementForm.value.announcement.price,
            description: announcementForm.value.announcement.description,
            mark: announcementForm.value.car.mark,
            model: announcementForm.value.car.model,
            year: announcementForm.value.car.year,
            body: announcementForm.value.car.body,
            colorBody: announcementForm.value.car.colorBody,
            km: announcementForm.value.car.km,
            hp: announcementForm.value.car.hp,
            fuelType: announcementForm.value.car.fuelTypeq,
            cm3: announcementForm.value.car.cm3,
            gearbox: announcementForm.value.car.gearbox,
            speeds: announcementForm.value.car.speeds,
            cylinders: announcementForm.value.car.cylinders,
            traction: announcementForm.value.car.traction,
            paint: announcementForm.value.car.paint,
            numberDoors: announcementForm.value.car.numberDoors,
            numberSeats: announcementForm.value.car.numberSeats,
            weight: announcementForm.value.car.weight
        };

        return this.http.post(this.BaseURI + '/Announcement/addCarAnnouncement', body)
    }
}