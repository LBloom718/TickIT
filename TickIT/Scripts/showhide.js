$(document).ready(Function) {
    if (HelpCenter.user.role == "User") {
        $("div.end_user").show();
    }

    if (HelpCenter.user.role == "Admin") {
        $("div.agent").show();
    }
}