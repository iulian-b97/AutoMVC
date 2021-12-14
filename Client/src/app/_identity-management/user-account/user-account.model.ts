export class UserAccount {
    userName: string
    email: string
    firstName: string
    lastName: string
    phoneNumber: string
    country: string

    constructor(userAccountResponse: any) {
        this.userName = userAccountResponse.userName
        this.email = userAccountResponse.email
        this.firstName = userAccountResponse.firstName
        this.lastName = userAccountResponse.lastName
        this.phoneNumber = userAccountResponse.phoneNumber
        this.country = userAccountResponse.country
    }
}