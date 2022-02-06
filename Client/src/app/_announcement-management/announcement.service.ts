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

    createMotorcycleAnnouncement(announcementForm: FormGroup) {
        var body = {
            title: announcementForm.value.announcement.title,
            price: announcementForm.value.announcement.price,
            description: announcementForm.value.announcement.description,
            mark: announcementForm.value.motorcycle.mark,
            model: announcementForm.value.motorcycle.model,
            year: announcementForm.value.motorcycle.year,
            body: announcementForm.value.motorcycle.body,
            colorBody: announcementForm.value.motorcycle.colorBody,
            km: announcementForm.value.motorcycle.km,
            hp: announcementForm.value.motorcycle.hp,
            cm3: announcementForm.value.motorcycle.cm3,
            gearbox: announcementForm.value.motorcycle.gearbox
        };
        return this.http.post(this.BaseURI + '/Announcement/addMotorcycleAnnouncement', body)
    }

    createTruckAnnouncement(announcementForm: FormGroup) {
        var body = {
            title: announcementForm.value.announcement.title,
            price: announcementForm.value.announcement.price,
            description: announcementForm.value.announcement.description,
            mark: announcementForm.value.truck.mark,
            model: announcementForm.value.truck.model,
            year: announcementForm.value.truck.year,
            body: announcementForm.value.truck.body,
            colorBody: announcementForm.value.truck.colorBody,
            km: announcementForm.value.truck.km,
            hp: announcementForm.value.truck.hp,
            fuelType: announcementForm.value.truck.fuelTypeq,
            cm3: announcementForm.value.truck.cm3,
            gearbox: announcementForm.value.truck.gearbox,
            speeds: announcementForm.value.truck.speeds,
            cylinders: announcementForm.value.truck.cylinders,
            traction: announcementForm.value.truck.traction,
            paint: announcementForm.value.truck.paint,
            numberDoors: announcementForm.value.truck.numberDoors,
            numberSeats: announcementForm.value.truck.numberSeats,
            weight: announcementForm.value.truck.weight
        };
        return this.http.post(this.BaseURI + '/Announcement/addTruckAnnouncement', body)
    }

    createVanAnnouncement(announcementForm: FormGroup) {
        var body = {
            title: announcementForm.value.announcement.title,
            price: announcementForm.value.announcement.price,
            description: announcementForm.value.announcement.description,
            mark: announcementForm.value.van.mark,
            model: announcementForm.value.van.model,
            year: announcementForm.value.van.year,
            body: announcementForm.value.van.body,
            colorBody: announcementForm.value.van.colorBody,
            km: announcementForm.value.van.km,
            hp: announcementForm.value.van.hp,
            cm3: announcementForm.value.van.cm3,
            gearbox: announcementForm.value.van.gearbox,
            speeds: announcementForm.value.van.speeds,
            cylinders: announcementForm.value.van.cylinders,
            traction: announcementForm.value.van.traction,
            paint: announcementForm.value.van.paint,
            numberDoors: announcementForm.value.van.numberDoors,
            numberSeats: announcementForm.value.van.numberSeats,
            weight: announcementForm.value.van.weight
        };
        return this.http.post(this.BaseURI + '/Announcement/addVanAnnouncement', body)
    }

    createTrailerAnnouncement(announcementForm: FormGroup) {
        var body = {
            title: announcementForm.value.announcement.title,
            price: announcementForm.value.announcement.price,
            description: announcementForm.value.announcement.description,
            mark: announcementForm.value.trailer.mark,
            model: announcementForm.value.trailer.model,
            year: announcementForm.value.trailer.year,
            body: announcementForm.value.trailer.body,
            colorBody: announcementForm.value.trailer.colorBody,
            numberDoors: announcementForm.value.trailer.numberDoors
        };
        return this.http.post(this.BaseURI + '/Announcement/addTrailerAnnouncement', body)
    }
}